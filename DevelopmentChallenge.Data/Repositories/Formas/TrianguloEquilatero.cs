using DevelopmentChallenge.Data.Resources;
using System;

namespace DevelopmentChallenge.Data.Repositories.Formas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal Lado { get; }
        public TrianguloEquilatero(decimal ancho)
        {
            Lado = ancho;
        }

        public decimal GetArea() 
        {
            return ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;
        }
        public decimal GetPerimetro()
        {
            return Lado * 3;
        }

        public string Label {
            get {
                return Strings.Triangulo;
            }
        }

        public string PluralLabel {
            get {
                return Strings.Triangulos;
            }
        }
    }
}
