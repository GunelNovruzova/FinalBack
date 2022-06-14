using Final.DAL;
using Final.Models;
using Final.ViewModels.Basket;
using Final.ViewModels.Products;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ProductController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddBasket(int? id, int count = 1)
        {
            if (id == null) return BadRequest();
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();
            string cookiebasket = HttpContext.Request.Cookies["basket"];
            List<BasketVM> basketVMs = null;


            if (!string.IsNullOrWhiteSpace(cookiebasket))
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(cookiebasket);
                if (basketVMs.Any(b => b.ProductId == id))
                {
                    basketVMs.Find(b => b.ProductId == id).Count += count;
                }
                else
                {
                    basketVMs.Add(new BasketVM
                    {
                        ProductId = (int)id,
                        Count = count
                    });
                }

            }
            else
            {
                basketVMs = new List<BasketVM>();
                basketVMs.Add(new BasketVM()
                {
                    ProductId = product.Id,
                    Count = count,
                });
            }
            HttpContext.Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketVMs));
            foreach (BasketVM basketVM in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketVM.ProductId);
                basketVM.Image = dbProduct.Image;
                basketVM.Price = dbProduct.Price;
                basketVM.Name = dbProduct.Name;
            }

            string coockieBasket = JsonConvert.SerializeObject(basketVMs);

            if (User.Identity.IsAuthenticated && !string.IsNullOrWhiteSpace(coockieBasket))
            {
                AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName.ToUpper() == User.Identity.Name.ToUpper());
                List<BasketVM> BasketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(coockieBasket);

                List<Basket> baskets = new List<Basket>();
                List<Basket> existedBasket = await _context.Baskets.Where(b => b.AppUserId == appUser.Id).ToListAsync();
                foreach (BasketVM basketVM in BasketVMs)
                {
                    if (existedBasket.Any(b => b.ProductId == basketVM.ProductId))
                    {
                        existedBasket.Find(b => b.ProductId == basketVM.ProductId).Count = basketVM.Count;
                    }
                    else
                    {
                        Basket basket = new Basket
                        {
                            AppUserId = appUser.Id,
                            ProductId = basketVM.ProductId,
                            Count = basketVM.Count,
                            CreatedAt = DateTime.UtcNow.AddHours(4)
                        };

                        baskets.Add(basket);
                    }


                }

                if (baskets.Count > 0)
                {
                    await _context.Baskets.AddRangeAsync(baskets);
                }
                await _context.SaveChangesAsync();
            }
              return PartialView("_BasketPartial", basketVMs);
        }

        public async Task<IActionResult> AddProdReview(string Message, int star, int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return PartialView("_LoginFormPartial");
            }
            if (id == null) return View();
            Review review = new Review();
            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name && !u.IsAdmin);
            review.Email = appUser.Email;
            review.Name = appUser.UserName;
            ProductVM productVM = new ProductVM()
            {
                Product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id),
                Reviews = await _context.Reviews.Where(p => p.ProductId == id && !p.IsDeleted).ToListAsync()
            };
            if (Message == null || Message == "" || Message.Trim() == null || Message.Trim() == "")
            {
                return PartialView("_ReviewPartial", productVM);
            }

            review.Message = Message.Trim();
            if (star == 0 || star < 0 || star > 5)
            {
                review.Star = 1;
            }
            else
            {
                review.Star = star;
            }
            review.ProductId = (int)id;
            review.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            productVM = new ProductVM()
            {
                Product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id),
                Reviews = await _context.Reviews.Where(p => p.ProductId == id && !p.IsDeleted).ToListAsync()
            };
            return PartialView("_AddReviewForProductPartial", productVM);
        }

        public async Task<IActionResult> SearchInput(string key)
        {
            List<Product> products = new List<Product>();
            if (key != null)
            {
                products = await _context.Products
                .Where(p => p.Name.Contains(key)
                || p.Description.Contains(key)
                || p.Price.ToString().Contains(key)
                || p.Category.Name.Contains(key)
                || p.ProductTags.Any(p => p.Tag.Name.Contains(key)))
                .ToListAsync();
            }
            return View(products);
        }
    }
}
