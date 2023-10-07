using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CursoCSharp_5_metodos
{
    public class Clases
    {

        int campo;
        string nombre { get; set; }
        readonly string identificador = "XX";


        //Constructir por defecto
        public Clases()
        {
        }

        //Metodo

        public void Calcular(int edad)
        {
            WriteLine(edad + 15);
        }

        public int sumar(int numero1,int numero2)
        {
            return numero1 + numero2;
        }
    }
}
