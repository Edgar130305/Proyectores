namespace WebApp.Models
{
    public class Proyector
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroDeSerie { get; set; }
        public SituacionProyector Situacion { get; set; }
        public DateTime FechDeAlta { get; set; }
        public DateTime FechDeBaja { get; set; }


    }

    public enum SituacionProyector
    {
        Bueno,
        Regular,
        Malo
    }
}
