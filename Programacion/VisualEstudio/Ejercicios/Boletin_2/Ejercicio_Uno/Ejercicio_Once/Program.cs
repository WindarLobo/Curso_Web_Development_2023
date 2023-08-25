using System.ComponentModel.Design;
using static System.Console;
namespace Ejercicio_Once;

internal class Program
{
    static void Main(string[] args)
    {

        /* Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana , 
         teniendo en cuenta que el 1 es Lunes, hacer con un switch.*/

        int usuario;

        do
        {
        
            WriteLine("Introduzca  un numero del 1 al 7 :");

             usuario = Convert.ToInt32(ReadLine());

            switch (usuario)
            {


                case 1:
                    WriteLine("Lunes");
                    break;

                case 2:
                    WriteLine("Martes");
                    break;

                case 3:
                    WriteLine("Miercoles");
                    break;

                case 4:
                    WriteLine("Jueves");
                    break;

                case 5:
                    WriteLine("Viernes");
                    break;

                case 6:
                    WriteLine("Sabado");
                    break;

                case 7:
                    WriteLine("Domingo");
                    break;

                default:
                    WriteLine("No existe");
                    break;
            }
                   ReadLine();

        } while (usuario > 7);
      
    }
}



