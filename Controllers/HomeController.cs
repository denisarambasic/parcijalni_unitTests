using IspitModul6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IspitModul6.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CheckCountValue(int i)
        { 
            if (i < 20)
            {
                //Zamislite da ovdje ide neka poslovna logika
            }
            else
            {
                throw new Exception("Broj je izvan raspona");
            }

            return View();
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
