using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_7_clasesabstracta
{
    public class ClaseDerivada : Clase
    {
        public override int Resta(int i, int z)
        {
            return i - z;
        }
    }
}
