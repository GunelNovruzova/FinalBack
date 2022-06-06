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
                Categories = await _context.Categories.Include(c => c.Blogs).Where(c => !c.IsDeleted).Take(8).ToListAsync(),
                Tags = await _context.Tags.Where(c => !c.IsDeleted).Take(8).ToListAsync()
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

                .FirstOrDefaultAsync(p => p.Id == (int)bid);
            if (blog == null) return NotFound();


            return View(blog);
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


            if (review.Message == null || review.Email == null || review.Name == null) return RedirectToAction("detail", new { rid });

            if (review.Star == null || review.Star < 0 || review.Star > 5)
            {
                review.Star = 1;
            }
            review.BlogId = (int)rid;
            review.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return RedirectToAction("detail", new { rid });
        }
    }
}
