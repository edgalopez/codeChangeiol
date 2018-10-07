using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Figura
    {
        public const int Castellano = 1;
        public const int Ingles = 2;

        public override decimal CalcularArea(decimal lado)
        {
            return lado * lado;
        }

        public override decimal CalcularPerimetro(decimal lado)
        {
            return lado * 4;
        }

    }
}
