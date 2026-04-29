using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.id = 2;
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "ligth";
            ViewBag.Numero_de_serie = "123456";
            ViewBag.Situacion = 1;
            ViewBag.fechaAlta = DateTime.Now.ToString("d");
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
