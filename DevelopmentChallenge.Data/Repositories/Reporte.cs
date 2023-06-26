
namespace DevelopmentChallenge.Data.Repositories
{
    public class Reporte
    {
        public string Nombre { get; set; }
        public int Count { get; set; }
        public decimal Area { get; set; }
        public decimal Perimetro { get; set; }
        
        public Reporte(string nombre)
        {
            Nombre = nombre;
            Count = 0;
            Area = 0m;
            Perimetro = 0m;
        }
    }
}
