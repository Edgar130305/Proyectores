using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()

        {
            return Content(
                "<p>Proyectores</p>" +
                "<p> Aqui se mostrara la informacion de un proyector especifico</p>",
                "text/html"
            );
        }

        public IActionResult Details(int id)
        {
            return Content(
                "<h1>Nuevo Proyector </h1>" +
                "<p> Aqui se mostrara la informacion del proyector  #" + id + "</p>",
                "text/html"
            );
        }


        public IActionResult Delete(int id)
        {
            return Content(
                "<h1>Dar de baja </h1>" +
                "<p> Aqui se dara de baja el proyector # " + id + "</p>",
                "text/html"
            );
        }

        public IActionResult Edit(int id)
        {
            return Content(
                "<h1>Editar </h1>" +
                "<p> Aqui se modificara la informacion del proyector # " + id + "</p>",
                "text/html"
            );
        }
    }
}
