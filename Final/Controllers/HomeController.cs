using Final.DAL;
using Final.Models;
using Final.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM {
                Products = await _context.Products
               .Where(p => !p.IsDeleted && p.CategoryId==2).ToListAsync(),
                Teams = await _context.Teams.Where(p => !p.IsDeleted).ToListAsync()
            };
            ViewBag.Category = await _context.Categories.Where(p=>p.Image != null).ToListAsync();
            return View(homeVM);
        }
        public async Task<IActionResult> CategoryFilter(int? id)
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == id && !p.IsDeleted).ToListAsync();

            return PartialView("_IndexCategoryPartial",product);
        }
        public async Task<IActionResult> Salad()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 6).Where(p => p.IsDeleted == false).ToListAsync();

            return View(product);
        }
        public async Task<IActionResult> Snack()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 17).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }
        public async Task<IActionResult> HotSnacks()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 9).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }
        public async Task<IActionResult> DryAged()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 2).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }
        public async Task<IActionResult> Burger()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 1).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }
        public async Task<IActionResult> GrilledMeats()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 5).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }
        public async Task<IActionResult> Dessert()
        {
            List<Product> product = await _context.Products.Where(p => p.CategoryId == 7).Where(p => p.IsDeleted == false).ToListAsync();
            return View(product);
        }

    }
}
