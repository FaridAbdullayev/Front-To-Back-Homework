using Front_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Front_To_Back.Controllers
{
    public class TeamController : Controller
    {
        private List<Team> _teams = new List<Team>();

        public TeamController()
        {
            _teams = new List<Team>
            {
                new Team
                {
                    Id = 1,
                    Name = "Walter White",
                    Work = "Chief Executive Officer",
                    Description = "Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"
                },
                new Team
                {
                    Id = 2,
                    Name = "Sarah Jhinson",
                    Work = "Product Manager",
                    Description = "Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus"
                },
                new Team
                {
                    Id = 3,
                    Name = "William Anderson",
                    Work = "CTO",
                    Description = "Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara"
                }
            };
        }
        public IActionResult Index()
        {
            return View(_teams);
        }
    }
}
