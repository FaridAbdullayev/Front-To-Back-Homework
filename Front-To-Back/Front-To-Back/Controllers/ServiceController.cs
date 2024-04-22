using Front_To_Back.Data;
using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class ServiceController : Controller
    {
        private AppDbContext _context;

        public ServiceController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            List<Service> list = _context.Services.ToList();
            return View(list);
        }
    }
}
