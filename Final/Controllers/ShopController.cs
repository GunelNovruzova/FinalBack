using Final.DAL;
using Final.Models;
using Final.ViewModels.Products;
using Final.ViewModels.Shop;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index(string sortby,int? cid,  int? tid, int page = 1)
        {
            
             List<Product> products = new List<Product>();


            switch (sortby)
            {
                case "AZ":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Name).ToListAsync();
                    break;
                case "ZA":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderByDescending(p => p.Name).ToListAsync();
                    break;
                case "LH":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Price).ToListAsync();
                    break;
                case "HL":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderByDescending(p => p.Price).ToListAsync();
                    break;
                default:
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Name).ToListAsync();
                    break;
            }
            if (cid != null)
            {
                products = await _context.Products.Where(p => p.CategoryId == cid).ToListAsync();

            }
            if (tid !=null)
            {
                products = await _context.Products
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                 .Where(p => p.ProductTags.Any(t => t.Tag.Id == tid))
                .ToListAsync();
            }
            ShopVM shopVM = new ShopVM
            {
                Products = products,
                Categories = await _context.Categories.Include(c => c.Products).Where(c => !c.IsDeleted).Take(4).ToListAsync(),
                Tags = await _context.Tags.Where(T => !T.IsDeleted).Take(4).ToListAsync()
            };
            ViewBag.PageIndex = page;
            ViewBag.PageCount = Math.Ceiling((double)_context.Products.Where(b => !b.IsDeleted).Count() / 6);

            return View(shopVM);
        }

        public async Task<IActionResult> Detail(int? pid)
        {
            ViewBag.Categories = await _context.Categories.ToListAsync();
            ViewBag.Tags = await _context.Tags.ToListAsync();

            if (pid == null) return BadRequest();

            Product product = await _context.Products
                .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                .FirstOrDefaultAsync(p => p.Id == (int)pid);

            if (product == null) return NotFound();

            ProductVM productVM = new ProductVM()
            {
                Product = product,

                Products = await _context.Products
                .Where(p => p.CategoryId == product.CategoryId)
                .Take(3)
                .OrderByDescending(p=>p.CreatedAt)
                .ToListAsync()
            };


            return View(productVM);
        }

        public async Task<IActionResult> Tag(int? tid)
        {
            if (tid == null) return BadRequest();
            Product product = await _context.Products
                 .Include(p => p.ProductTags).ThenInclude(pt => pt.Tag)
                 .FirstOrDefaultAsync(p => p.Id == (int)tid);
            if (product == null) return NotFound();
            ProductVM productVM = new ProductVM()
            {
                Product = product,

                Products = await _context.Products
             .Where(p => p.TagIds == product.TagIds)
             .Take(3)
             .OrderByDescending(p => p.CreatedAt)
             .ToListAsync()
            };
            return View(productVM);
        }
       

    }
}
