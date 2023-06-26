using DevelopmentChallenge.Data.Resources;
using System;
namespace DevelopmentChallenge.Data.Repositories.Formas
{
    public class Trapecio : IFormaGeometrica
    {
        public decimal BaseMenor { get; }
        public decimal BaseMayor { get; }
        public decimal Lado1 { get; }
        public decimal Lado2 { get; }
        public decimal Altura { get; }
        public Trapecio(decimal baseMenor, decimal baseMayor, decimal lado1, decimal lado2, decimal altura) {
            BaseMenor = baseMenor;
            BaseMayor = baseMayor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public decimal GetArea() {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }
        public decimal GetPerimetro()
        {
            return (Lado1 + BaseMenor + Lado2 + BaseMayor);
        }

        public string Label
        {
            get
            {
                return Strings.Trapecio;
            }
        }

        public string PluralLabel
        {
            get
            {
                return Strings.Trapecios;
            }
        }
    }
}
