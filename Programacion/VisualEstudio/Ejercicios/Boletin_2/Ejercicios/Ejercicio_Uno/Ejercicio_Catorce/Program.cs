using static System.Console;
namespace Ejercicio_Catorce;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa calcule cuantas cifras tiene un número entero positivo
         (pista: se puede hacer dividiendo varias veces entre 10).*/


       
        do {

            WriteLine("Introduce un número entero positivo: ");

            string usuario = ReadLine();

        if (int.TryParse(usuario, out int numero)) 
              
                if (numero > 0)
                 {

                WriteLine("\nEl número de digitos es {0}.", usuario.Length);

                    break;

                }
           
        } while(true);

    }
}