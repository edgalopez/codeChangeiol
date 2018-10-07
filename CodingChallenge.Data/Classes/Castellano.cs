using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Castellano : Idioma
    {
       public override string TraducirFigura(int tipo, int cantidad, int idioma)
        {
            string traduccion = "";
            switch (tipo)
            {
                case 1:
                    traduccion = cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    break;
                case 2:
                    traduccion = cantidad == 1 ? "Triángulo" : "Triángulos";
                    break;
                case 3:
                    traduccion = cantidad == 1 ? "Círculo" : "Círculos";
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
                    traduccion = "Área";
                    break;
                case "P":
                    traduccion = "Perímetro";
                    break;
                case "F":
                    traduccion = "formas";
                    break;
                case "L":
                    traduccion = "<h1>Lista vacía de formas!</h1>";
                    break;
                case "R":
                    traduccion = "<h1>Reporte de Formas</h1>";
                    break;
            }
            return traduccion;
        }


    }
}
