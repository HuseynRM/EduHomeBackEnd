using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.DAL;
using ProjectFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AboutController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            AboutViewModel aboutViewModel = new AboutViewModel()
            {
                aboutEduHome = await _context.AboutEduHomes.FirstOrDefaultAsync(x => !x.IsHome),
                Teachers = await _context.Teachers.Take(4).ToListAsync(),
                Testimonials = await _context.Testimonials.ToListAsync(),
                Settings = await _context.Settings.ToListAsync(),
                NoticeBoardItems =await _context.NoticeBoardItems.ToListAsync(),
            };
            return View(aboutViewModel);
        }
    }
}
