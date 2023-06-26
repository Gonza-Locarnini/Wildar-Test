
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Repositories.Formas
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal Lado { get; }
        public Cuadrado(decimal ancho)
        {
            Lado = ancho;
        }

        public decimal GetArea() 
        {
            return Lado * Lado;
        }
        public decimal GetPerimetro()
        {
            return Lado * 4;
        }

        public string Label
        {
            get
            {
                return Strings.Cuadrado;
            }
        }

        public string PluralLabel
        {
            get
            {
                return Strings.Cuadrados;
            }
        }
    }
}
