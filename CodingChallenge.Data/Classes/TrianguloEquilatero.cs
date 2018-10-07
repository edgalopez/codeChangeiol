using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class TrianguloEquilatero : Figura
    {
        public const int Castellano = 1;
        public const int Ingles = 2;

        public override decimal CalcularArea(decimal lado)
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public override decimal CalcularPerimetro(decimal lado)
        {
            return lado * 3;
        }

    }
}
