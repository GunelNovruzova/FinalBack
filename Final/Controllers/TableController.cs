using Final.DAL;
using Final.Models;
using Final.ViewModels.Table;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class TableController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public TableController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Index()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            Table table = _context.Tables.FirstOrDefault();
            TableVM tableVM = new TableVM()
            {
                Setting = setting
            };
            return View(tableVM);
        }
        public async Task<IActionResult> TableReservation(Table table)
        {

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }


            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name && !u.IsAdmin);


            if (string.IsNullOrWhiteSpace(table.Name))
            {
                ModelState.AddModelError("Name", "There should be no gaps");
                return View();
            }

            if (string.IsNullOrWhiteSpace(table.Email))
            {
                ModelState.AddModelError("Email", "There should be no gaps");
                return View();
            }
            table.MainEmail = appUser.Email;

            table.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Tables.AddAsync(table);
            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

    }
}
