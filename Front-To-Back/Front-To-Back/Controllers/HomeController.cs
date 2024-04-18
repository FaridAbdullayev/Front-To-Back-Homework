using Front_To_Back.Models;
using Front_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private List<Feature> _feature = new List<Feature>();
        private List<Service> _service = new List<Service>();

        public HomeController()
        {
            _feature = new List<Feature>
            {
                new Feature
                {
                    Id = 1,
                    Name = "Lorem Ipsum",
                    Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"
                },
                 new Feature
                {
                    Id = 2,
                    Name = "Dolor Sitema",
                    Description = "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"
                },
                  new Feature
                {
                    Id = 3,
                    Name = "Sed ut perspiciatis",
                    Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"
                },

            };

            _service = new List<Service>
            {
                new Service
                {
                    Id= 1,
                    Name = "Lorem Ipsum",
                    Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"
                },
                new Service
                {
                    Id= 2,
                    Name = "Sed ut perspiciatis",
                    Description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"
                },
                new Service
                {
                    Id= 3,
                    Name = "Magni Dolores",
                    Description = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"
                },
                new Service
                {
                    Id= 4,
                    Name = "Nemo Enim",
                    Description = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"
                },
                new Service
                {
                    Id= 5,
                    Name = "Dele cardo",
                    Description = "Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"
                },
                new Service
                {
                    Id= 6,
                    Name = "Divera don",
                    Description = "Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"
                }
            };
        }

        public IActionResult Index()
        {

            HomeViewModel model = new HomeViewModel()
            {
                Features = _feature,
                Services = _service
            };
            return View(model);
        }
    }
}
