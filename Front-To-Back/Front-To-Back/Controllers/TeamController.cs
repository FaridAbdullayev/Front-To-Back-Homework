using Front_To_Back.Data;
using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class TeamController : Controller
    {
        private AppDbContext _context;

        public TeamController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList();
            return View(teams);
        }
    }
}
