using Final.DAL;
using Final.Models;
using Final.ViewModels.Contact;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        private readonly UserManager<AppUser> _userManager;

        public ContactController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            Contact contact = _context.Contacts.FirstOrDefault();
            ContactVM contactVM = new ContactVM()
            {
                Setting = setting,
                Contact = contact
            };
            return View(contactVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContactMessage(ContactVM contactVM)
        {
            
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("login", "account");
            }


            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == User.Identity.Name && !u.IsAdmin);


            if (string.IsNullOrWhiteSpace(contactVM.Contact.Name))
            {
                ModelState.AddModelError("Name", "There should be no gaps");
                return View();
            }

            if (string.IsNullOrWhiteSpace(contactVM.Contact.Message))
            {
                ModelState.AddModelError("Message", "There should be no gaps");
                return View();
            }
            if (string.IsNullOrWhiteSpace(contactVM.Contact.Email))
            {
                ModelState.AddModelError("Email", "There should be no gaps");
                return View();
            }
            contactVM.Contact.MainEmail = appUser.Email;
            contactVM.Contact.Message = contactVM.Contact.Message;

            contactVM.Contact.CreatedAt = DateTime.UtcNow.AddHours(4);

            await _context.Contacts.AddAsync(contactVM.Contact);
            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }
    }
}
