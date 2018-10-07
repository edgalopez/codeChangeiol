using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Figura
    {
        public abstract decimal CalcularArea(decimal lado);
        public abstract decimal CalcularPerimetro(decimal lado);

    }
}
