using Final.DAL;
using Final.Models;
using Final.ViewModels.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;


        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index(int? cid, int? tid, int page = 1)
        {
            ViewBag.cid = cid;
            ViewBag.tid = tid;

            IQueryable<Blog> blogs = _context.Blogs.Where(b => !b.IsDeleted);

            if (cid != null)
            {
                blogs = blogs.Where(b => b.CategoryId == cid);

            }
            if (tid != null)
            {
                blogs = blogs
                .Include(b => b.BlogTags).ThenInclude(bt => bt.Tag)
                 .Where(b => b.BlogTags.Any(t => t.Tag.Id == tid));
            }

            BlogVM blogVM = new BlogVM
            {
                Blogs = blogs.Skip((page - 1) * 6).Take(3).ToList(),
                Categories = await _context.Categories.Include(c => c.Blogs).Where(c => !c.IsDeleted).Take(12).ToListAsync(),
                Tags = await _context.Tags.Where(c => !c.IsDeleted).Take(12).ToListAsync()
            };
            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 6);
            return View(blogVM);
        }

        public async Task<IActionResult> Detail(int? bid)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Tags = await _context.Tags.ToListAsync();

            ViewBag.Blogs = await _context.Blogs.OrderByDescending(b => b.CreatedAt).Take(4).ToListAsync();

            if (bid == null) return BadRequest();
            Blog blog = await _context.Blogs
                 .Include(b => b.Reviews)
                .FirstOrDefaultAsync(p => p.Id == (int)bid);
            if (blog == null) return NotFound();

            BlogVM blogVM = new BlogVM()
            {
                Blog=blog,
                Reviews = await _context.Reviews.Where(b=>b.BlogId==blog.Id).OrderByDescending(b=>b.CreatedAt).ToListAsync()


            };
            return View(blogVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddReview(Review review, int? rid)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }
            if (rid == null) return View();

            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name && !u.IsAdmin);

            review.Email = appUser.Email;
            review.Name = appUser.UserName;

            int bid = (int)rid;

            if (review.Message == null || review.Email == null || review.Name == null) return RedirectToAction("detail", new { bid });

            if (review.Star == null || review.Star < 0 || review.Star > 5)
            {
                review.Star = 1;
            }
            review.BlogId = (int)rid;
            review.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("detail", new { bid });
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return BadRequest();
            Review dbReview = await _context.Reviews
                .Include(r => r.Blog)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (dbReview == null) return NotFound();

            return View(dbReview);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Review review)
        {
            if (id == null) return BadRequest();
            Review dbReview = await _context.Reviews.FirstOrDefaultAsync(r => r.Id == id);
            if (dbReview == null) return NotFound();

            if (review.Id != id) return BadRequest();

            Blog blog = await _context.Blogs.FirstOrDefaultAsync(b => b.Reviews.FirstOrDefault(r => r.Id == id).Id == id);

            dbReview.Message = review.Message;
            dbReview.UpdatedAt = DateTime.UtcNow.AddHours(4);
            int bid = blog.Id;
            await _context.SaveChangesAsync();
            return RedirectToAction("detail", new { bid });
        }
    }
} 
