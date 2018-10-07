using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Frances : Idioma
    {
        public override string TraducirFigura(int tipo, int cantidad, int idioma)
        {
            string traduccion = "";
            switch (tipo)
            {
                case 1:
                    traduccion = cantidad == 1 ? "Carré" : "Carrés";
                    break;
                case 2:
                    traduccion = cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case 3:
                    traduccion = cantidad == 1 ? "Cercle" : "Cercles";
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
                    traduccion = "Zones";
                    break;
                case "P":
                    traduccion = "Périmètre";
                    break;
                case "F":
                    traduccion = "formes";
                    break;
                case "L":
                    traduccion = "<h1>Liste du formes vide!</h1>";
                    break;
                case "R":
                    traduccion = "<h1>Raport du formes</h1>";
                    break;
            }
            return traduccion;
        }
    }
}
