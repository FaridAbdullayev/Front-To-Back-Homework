using Front_To_Back.Data;
using Front_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Front_To_Back.Controllers
{
    public class PortfolioController : Controller
    {

        private AppDbContext _appDbContext;

        public PortfolioController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            PortfolioViewModel model = new PortfolioViewModel
            {
                Categories = _appDbContext.Category.ToList(),
                Projects = _appDbContext.Projects.Include(x=>x.Category).Include(x=>x.ProjectImages).ToList(),
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var detail = _appDbContext.Projects.Include(x=>x.Category).Include(x=>x.ProjectImages).FirstOrDefault(x => x.Id == id);

            return View(detail);
        }
    }
}
