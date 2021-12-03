using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectFinal.DAL;
using ProjectFinal.Models;
using ProjectFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            BlogVM blogVM = new BlogVM
            {
                BlogMore = await _context.BlogMores.Include(x => x.BlogReadMore).Where(b => b.Isdeleted == false).ToListAsync(),
            };
            return View(blogVM);
        }
        public async Task<IActionResult> ReadMore(int? id)
        {
            BlogMore blogMore = await _context.BlogMores.Include(x => x.BlogReadMore).FirstOrDefaultAsync(x => x.Id == id);
            if (blogMore == null)
            {
                return NotFound();
            }
            return View(blogMore);
        }
    }
}
