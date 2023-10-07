using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_7_clasesabstracta
{
    public abstract class ClaseAbstracta
    {

        public abstract int Sumar(int i, int z);
        public virtual int Resta(int i, int z)
        {

            return i - z;
        }
    }
}
