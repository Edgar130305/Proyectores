using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["id"] = "1";
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "Xligth";
            ViewData["Numero de serie"] = "123456";
            ViewData["Situacion"] = 1;
            ViewData["fechaAlta"] = DateTime.Now.ToString("da");
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
