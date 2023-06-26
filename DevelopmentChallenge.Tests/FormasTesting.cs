using NUnit.Framework;
using DevelopmentChallenge.Data.Services;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Repositories;
using DevelopmentChallenge.Data.Repositories.Formas;

namespace DevelopmentChallenge.Tests
{
    public class FormasTesting
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReporteCuadrados()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
            var reporte = new ReporteServices().Imprimir(formas);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>Total:<br/>3 shapes Perimeter 36 Area 35", reporte);
        }

        [Test]
        public void TestReporteListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var reporte = new ReporteServices().Imprimir(formas, Lang.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13,01 | Perimetro 18,06 <br/>3 Triangulos | Area 49,64 | Perimetro 51,6 <br/>Total:<br/>7 formas Perimetro 97,66 Area 91,65", reporte);
        }

        [Test]
        public void TestReporteListaConMasTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Rectangulo(8, 4),
                new TrianguloEquilatero(4),
                new Trapecio(4, 6, 4, 4, 3.5m),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
            var reporte = new ReporteServices().Imprimir(formas, Lang.Italiano);

            Assert.AreEqual("<h1>Rapporto sui moduli</h1>1 Piazza | La zona 25 | Perimetro 20 <br/>1 Rettangolo | La zona 32 | Perimetro 24 <br/>3 Triangoli | La zona 49,64 | Perimetro 51,6 <br/>1 Trapezio | La zona 17,5 | Perimetro 18 <br/>1 Cerchio | La zona 5,94 | Perimetro 8,64 <br/>Totale:<br/>7 Forme Perimetro 122,24 La zona 130,08", reporte);
        }
    }
}