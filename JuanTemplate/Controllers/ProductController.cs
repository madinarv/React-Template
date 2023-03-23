using JuanTemplate.DataAccesLayer;
using JuanTemplate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JuanTemplate.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContex _context;
        //private readonly UserManager<AppUser> _userManager;

        public ProductController(AppDbContex context)
        {
            _context = context;
            //_userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ProductModal(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return PartialView("_ModalPartial", product);

        }
    }
}
