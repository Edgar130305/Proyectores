using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = LoadData();
            //var modelo= new LinkedList<Proyector>();

            return View(modelo);
        }
        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();

            proyectores.Add(new Proyector()
            {
                id = 1,
                Marca = "Epson",
                Modelo = "Star",
                NumeroDeSerie = "4324324",
                Situacion = SituacionProyector.Bueno,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                id = 2,
                Marca = "Hp",
                Modelo = "Ultra",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Regular,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                id = 3,
                Marca = "Luna",
                Modelo = "ligth",
                NumeroDeSerie = "14326",
                Situacion = SituacionProyector.Malo,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                id = 4,
                Marca = "Epson",
                Modelo = "Gold",
                NumeroDeSerie = "1375",
                Situacion = SituacionProyector.Bueno,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            });

            proyectores.Add(new Proyector()
            {
                id = 5,
                Marca = "Epson",
                Modelo = "ligth",
                NumeroDeSerie = "123456",
                Situacion = SituacionProyector.Regular,
                FechDeAlta = DateTime.Now,
                FechDeBaja = DateTime.Now
            });
            return proyectores;
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
