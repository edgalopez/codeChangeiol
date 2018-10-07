using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    class Circulo : Figura
    {
        public const int Castellano = 1;
        public const int Ingles = 2;

        public override decimal CalcularArea(decimal lado)
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public override decimal CalcularPerimetro(decimal lado)
        {
            return (decimal)Math.PI * lado;
        }
    }
}
