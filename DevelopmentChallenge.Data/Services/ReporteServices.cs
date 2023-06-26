/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Resources;
using DevelopmentChallenge.Data.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DevelopmentChallenge.Data.Services
{
    public class ReporteServices
    {
        public string Imprimir(List<IFormaGeometrica> formas, string culture = Lang.Ingles)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            
            var map = new Dictionary<string, Reporte>();

            var sb = new StringBuilder();

            if (!formas.Any())
                sb.Append("<h1>" + Strings.ListaVacia + "</h1>");
            else
            {
                sb.Append("<h1>" + Strings.ReporteFormas + "</h1>");

                var totalA = 0m;
                var totalP = 0m;
                int totalF = 0;

                for (int i = 0; i < formas.Count; i++)
                {
                    var n = formas[i].GetType().Name;
                    if (map.ContainsKey(n))
                        map[n].Nombre = formas[i].PluralLabel;
                    else
                        map.Add(n, new Reporte(formas[i].Label));

                    map[n].Count++;
                    map[n].Area += formas[i].GetArea();
                    map[n].Perimetro += formas[i].GetPerimetro();
                }

                foreach(var item in map)
                {
                    totalF += item.Value.Count;
                    totalA += item.Value.Area;
                    totalP += item.Value.Perimetro;

                    sb.Append(item.Value.Count + " " + item.Value.Nombre);
                    sb.Append($" | {Strings.Area} {item.Value.Area:#.##}");
                    sb.Append($" | {Strings.Perimetro} {item.Value.Perimetro:#.##} ");
                    sb.Append("<br/>");
                }

                sb.Append(Strings.Total + ":<br/>");
                sb.Append(totalF + " " + Strings.Formas + " ");
                sb.Append(Strings.Perimetro + $" {totalP:#.##} ");
                sb.Append(Strings.Area + $" {totalA:#.##}");

            }

            return sb.ToString();
        }
    }
}
