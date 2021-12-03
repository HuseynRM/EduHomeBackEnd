﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjectFinal.DAL;
using ProjectFinal.Models;
using ProjectFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ContactController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            ContactAndSettingViewModel viewModel = new ContactAndSettingViewModel()
            {
                Setting = _context.Settings.First(),
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetContact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("index");
            }
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
