﻿using Final.DAL;
using Final.Extensions;
using Final.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BlogController : Controller
    {
       
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index(bool? status, int page = 1)
        {
            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs
                    .Include(p => p.BlogTags).ThenInclude(pt => pt.Tag)
                      .Include(t => t.Category)


                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);

            return View(blogs.Skip((page - 1) * 5).Take(5));
        }

        public async Task<IActionResult> Create(bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
           return View();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog, bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!await _context.Categories.AnyAsync(b => b.Id == blog.CategoryId && !b.IsDeleted))
            {
                ModelState.AddModelError("CategoryId", "Choose the right category");
                return View();
            }

            if (blog.TagIds.Count > 0)
            {
                List<BlogTag> blogTags = new List<BlogTag>();

                foreach (int item in blog.TagIds)
                {
                    if (!await _context.Tags.AnyAsync(t => t.Id != item && !t.IsDeleted))
                    {
                        ModelState.AddModelError("TagIds", $"The selected Id {item}  Tag is wrong");
                        return View();
                    }

                    BlogTag blogTag = new BlogTag
                    {
                        TagId = item
                    };

                    blogTags.Add(blogTag);
                }

                blog.BlogTags = blogTags;
            }
            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("ImageFile", "The selected image type doesn't match");
                    return View();
                }

                if (!blog.ImageFile.CheckFileSize(100000))
                {
                    ModelState.AddModelError("ImageFile", "The Size of the Selected Image Can Be Maximum 10000 Kb");
                    return View();
                }

                blog.Image = blog.ImageFile.CreateFile(_env, "assets", "img", "blogs");
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Image must be selected");
                return View();
            }
           blog.CreatedAt = DateTime.UtcNow.AddHours(4);
           await _context.Blogs.AddAsync(blog);
           await _context.SaveChangesAsync();
           return RedirectToAction("index", new { status, page });
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return BadRequest();

            Blog blog = _context.Blogs
                .Include(p => p.Category)
               .Include(p => p.BlogTags).ThenInclude(pt => pt.Tag)
                .FirstOrDefault(p => p.Id == id);

            if (blog == null) return NotFound();

            return View(blog);
        }
        public async Task<IActionResult> Update(int? id, bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
           
            Blog blog = await _context.Blogs.Include(p => p.BlogTags)
                .ThenInclude(pt => pt.Tag).FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            return View(blog);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog, bool? status, int page = 1)
        {
            ViewBag.Categories = await _context.Categories.Where(b => !b.IsDeleted).ToListAsync();
            ViewBag.Tags = await _context.Tags.Where(t => !t.IsDeleted).ToListAsync();
            Blog dbBlog = await _context.Blogs
            .Include(p => p.BlogTags).ThenInclude(pt => pt.Tag)
            .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);
            if (!ModelState.IsValid)
            {
                return View();
            }



            if (!await _context.Categories.AnyAsync(b => b.Id == blog.CategoryId && !b.IsDeleted))
            {
                ModelState.AddModelError("CategoryId", "Choose the right category");
                return View();
            }

            if (blog.TagIds.Count > 0)
            {
                List<BlogTag> blogTags = new List<BlogTag>();

                foreach (int item in blog.TagIds)
                {
                    if (!await _context.Tags.AnyAsync(t => t.Id != item && !t.IsDeleted))
                    {
                        ModelState.AddModelError("TagIds", $"The selected Id {item}  Tag is wrong");
                        return View();
                    }

                    BlogTag blogTag = new BlogTag
                    {
                        TagId = item
                    };

                    blogTags.Add(blogTag);
                }

                blog.BlogTags = blogTags;
            }

            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.CheckFileContentType("image/jpeg"))
                {
                    ModelState.AddModelError("ImageFile", "The selected image type doesn't match");
                    return View();
                }

                if (!blog.ImageFile.CheckFileSize(100000))
                {
                    ModelState.AddModelError("ImageFile", "The Size of the Selected Image Can Be Maximum 10000 Kb");
                    return View();
                }

                dbBlog.Image =blog.ImageFile.CreateFile(_env, "assets", "img", "blogs");

            }


            dbBlog.Title = blog.Title;
            dbBlog.Description = blog.Description;
         
            
            dbBlog.BlogTags = blog.BlogTags;
          
            dbBlog.ImageFile = blog.ImageFile;

            dbBlog.TagIds = blog.TagIds;
            dbBlog.CategoryId = blog.CategoryId;

            dbBlog.UpdatedAt = DateTime.UtcNow.AddHours(4);
            await _context.SaveChangesAsync();

            return RedirectToAction("index", new { status, page });
        }
        public async Task<IActionResult> Delete(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);

            if (dbBlog == null) return NotFound();

            dbBlog.IsDeleted = true;
            dbBlog.DeletedAt = DateTime.UtcNow.AddHours(4);

            await _context.SaveChangesAsync();

            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs

                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);



            return PartialView("_BlogIndexPartial", blogs.Skip((page - 1) * 5).Take(5));
        }
        public async Task<IActionResult> Restore(int? id, bool? status, int page = 1)
        {
            if (id == null) return BadRequest();

            Blog dbBlog = await _context.Blogs.FirstOrDefaultAsync(t => t.Id == id);

            if (dbBlog == null) return NotFound();

            dbBlog.IsDeleted = false;

            await _context.SaveChangesAsync();

            ViewBag.Status = status;

            IEnumerable<Blog> blogs = await _context.Blogs

                .Where(t => status != null ? t.IsDeleted == status : true)
                .OrderByDescending(t => t.CreatedAt)
                .ToListAsync();

            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)blogs.Count() / 5);



            return PartialView("_BlogIndexPartial", blogs.Skip((page - 1) * 5).Take(5));
        
        }




    }
}
