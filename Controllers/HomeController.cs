using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class Vertegenwoordiger
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class HomeController : Controller
    {
        private List<Vertegenwoordiger> _listVertegenwoordigers;

        public IActionResult Index()
        {

            _listVertegenwoordigers = new List<Vertegenwoordiger>
            {
                new Vertegenwoordiger{ID = 1,Name = "Jos"},
                new Vertegenwoordiger{ID = 2,Name = "Pol"},
                new Vertegenwoordiger{ID = 3,Name = "Tom"}
            };
            return View(_listVertegenwoordigers);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
