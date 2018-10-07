using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Ingles : Idioma
    {
        public override string TraducirFigura(int tipo, int cantidad, int idioma)
        {
            string traduccion = "";
            switch (tipo)
            {
                case 1:
                    traduccion = cantidad == 1 ? "Square" : "Squares";
                    break;
                case 2:
                    traduccion = cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case 3:
                    traduccion = cantidad == 1 ? "Circle" : "Circles";
                    break;
            }
            return traduccion;
        }

        public override string TraducirTitulo(string tipoTitulo)
        {
            string traduccion = "";
            switch (tipoTitulo)
            {
                case "A":
                    traduccion = "Area";
                    break;
                case "P":
                    traduccion = "Perimeter";
                    break;
                case "F":
                    traduccion = "shapes";
                    break;
                case "L":
                    traduccion = "<h1>Empty list of shapes!</h1>";
                    break;
                case "R":
                    traduccion = "<h1>Shapes report</h1>";
                    break;

            }
            return traduccion;
        }
    }
}
