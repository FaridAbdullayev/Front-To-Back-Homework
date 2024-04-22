using Front_To_Back.Data;
using Front_To_Back.Models;
using Front_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext appDbContext)
        {
            _context= appDbContext;
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Services = _context.Services.ToList(),
                Features = _context.Features.ToList(),
                Slider = _context.HomeSlider.ToList(),
            };
            return View(model);
        }

      
    }
}
