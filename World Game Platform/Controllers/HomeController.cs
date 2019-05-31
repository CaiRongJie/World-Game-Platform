using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using World_Game_Platform.Models;

namespace World_Game_Platform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return base.View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return base.View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return base.View();
        }
        public ActionResult Steam()
        {
            return base.View();
        }
     public ActionResult Origin()
        {
            return base.View();
        }
        public ActionResult uplay()
        {
            return base.View();
        }
        public ActionResult epic()
        {
            return base.View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }

        public IActionResult Privacy()
        {
            return base.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Search()
        {
            return base.View();
        }
        [HttpPost]
        public IActionResult Search(string query)
        {
            var q = query;
            return base.View();
        }
    }
}
