using JuanTemplate.DataAccesLayer;
using JuanTemplate.Models;
using JuanTemplate.ViewModels.HomeViemModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContex _context;

        public HomeController(AppDbContex context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVm vm = new HomeVm
            {
                Sliders = await _context.Sliders.Where(s => s.IsDeleted == false).ToListAsync(),
                Products = await _context.Products.Where(p => p.IsDeleted == false).ToListAsync(),
                Blogs = await _context.Blogs.Where(s => s.IsDeleted == false).ToListAsync(),
                TopSellers = await _context.Products.Where(s => s.IsDeleted==false && s.IsTopSeller ).ToListAsync()
            };
            return View(vm);
        }
    }
}
