using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        public abstract string TraducirFigura(int tipo, int cantidad, int idioma);
        public abstract string TraducirTitulo(string tipoTitulo);
    }
}
