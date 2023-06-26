using DevelopmentChallenge.Data.Resources;
using System;
namespace DevelopmentChallenge.Data.Repositories.Formas
{
    public class Circulo : IFormaGeometrica
    {
        public decimal Lado { get; }
        public Circulo(decimal ancho) { 
            Lado = ancho;
        }

        public decimal GetArea() {
            return (decimal)Math.PI * (Lado / 2) * (Lado / 2);
        }
        public decimal GetPerimetro()
        {
            return (decimal)Math.PI * Lado;
        }

        public string Label
        {
            get
            {
                return Strings.Circulo;
            }
        }

        public string PluralLabel
        {
            get
            {
                return Strings.Circulos;
            }
        }
    }
}
