using DevelopmentChallenge.Data.Resources;
using System;
namespace DevelopmentChallenge.Data.Repositories.Formas
{
    public class Rectangulo : IFormaGeometrica
    {
        public decimal Alto { get; }
        public decimal Ancho { get; }
        public Rectangulo(decimal alto, decimal ancho) {
            Alto = alto;
            Ancho = ancho;
        }

        public decimal GetArea() {
            return Alto * Ancho;
        }
        public decimal GetPerimetro()
        {
            return (Alto * 2) + (Ancho * 2);
        }

        public string Label
        {
            get
            {
                return Strings.Rectangulo;
            }
        }

        public string PluralLabel
        {
            get
            {
                return Strings.Rectangulos;
            }
        }
    }
}
