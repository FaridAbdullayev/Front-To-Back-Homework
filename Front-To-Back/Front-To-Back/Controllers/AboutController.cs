using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
