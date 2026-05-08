using WebApp.Models;

namespace WebApp.Services
{
    public class ProyectoresEnMemoriaService : IProyectoresService
    {
        private static List<Proyector> _proyectores= LoadData();
        public void AddProyector(Proyector proyector)
        {
            if(proyector != null)
            {
                _proyectores.Add(proyector);
            }
        }

        public IEnumerable<Proyector> GetAll()
        {
            return _proyectores;
        }
        private static List<Proyector> LoadData()
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

    }
}

