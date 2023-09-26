using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CursoCSharp_5_poliformismo;

public class Gato : Animal

{
    public override void HacerRuido()
    {
        WriteLine("El gato hace miiiiau");
    }
}
