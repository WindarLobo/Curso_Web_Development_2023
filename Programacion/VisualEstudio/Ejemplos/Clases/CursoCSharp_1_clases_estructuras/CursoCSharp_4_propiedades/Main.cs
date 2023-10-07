using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CursoCSharp_4_propiedades
{
      class Propiedades
    {
        static void Main(string[] args)
        {
            //Clase clase = new Clase();
            //clase.Campo = 12;
            //clase.Apellidos = "Lopez Serrano";

            //WriteLine(clase.Edad);
            //ReadLine();


            Clase clase2 = new Clase();
            var estado = clase2.Estado;
            clase2.Estado = 5;

            WriteLine(clase2.Edad);
            clase2.Metodo(28);

            WriteLine(clase2.Edad); 
            ReadLine();
        }
    }
}
