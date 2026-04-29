using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Proyector proyector = new Proyector()
            {
                id = 2,
                Marca = "Epson",
                Modelo = "ligth",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Bueno,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            };

            return View(proyector);
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
