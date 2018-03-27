using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LightSeekerDeckBuilder.App.Models;
using LightSeekerDeckBuilder.Data.DataStore;

namespace LightSeekerDeckBuilder.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CardStorage.LoadData();
            return View(CardStorage.Library);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
