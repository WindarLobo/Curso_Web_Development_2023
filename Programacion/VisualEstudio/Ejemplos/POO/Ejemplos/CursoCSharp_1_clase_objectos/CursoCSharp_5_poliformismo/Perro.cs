using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace CursoCSharp_5_poliformismo;

public class Perro : Animal
{
    public override void HacerRuido()
    {
        WriteLine("El perro hace Guau Guau"); 
    }
}
