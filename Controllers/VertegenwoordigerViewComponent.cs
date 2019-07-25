using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Models;

namespace Test.Controllers
{
    public class VertegenwoordigerViewComponent: ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return  View("VertegenwoordigerView",new VertegenwoordigerModel());
        }

        // POST: Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IViewComponentResult Create([Bind("Name")] VertegenwoordigerModel vwm)
        {
            if (ModelState.IsValid)
            {

                return View("VertegenwoordigerView", new VertegenwoordigerModel());
            }
            return View("VertegenwoordigerView", vwm);
        }
    }
}
