using Final.DAL;
using Final.Models;
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
        public async Task <IActionResult> Index(string sortby, int page = 1)
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
                case "PAZ":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Name).ToListAsync();
                    break;
                case "PZA":
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Name).ToListAsync();
                    break;
                default:
                    products = await _context.Products.Where(p => !p.IsDeleted).Skip((page - 1) * 6).Take(6).OrderBy(p => p.Name).ToListAsync();
                    break;
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

    }
}
