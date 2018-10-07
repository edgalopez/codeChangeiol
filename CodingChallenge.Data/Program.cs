using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data
{
    class Program
    {
        public static void Main()
        {
            string result = "";

            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
                new FormaGeometrica(FormaGeometrica.Circulo, 3),
                new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
                new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
            };

            result = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            Console.WriteLine(result);
            String y = Console.ReadLine();
        }
    }
}