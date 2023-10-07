using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_7_clasesabstracta
{
    public abstract class Clase : ClaseAbstracta
    {
        public override int Sumar(int i, int z)
        {
            return i + z;
        }

        public abstract override int Resta(int i, int z);

    }
}
