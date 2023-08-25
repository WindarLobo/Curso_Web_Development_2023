using static System.Console;
namespace Ejercicio_Trece;

internal class Program
{
    static void Main(string[] args)
    {
        /* Comprobar si un numero introducido por consola es primo*/

        WriteLine("Introduce un numero");

        int numeroIntroducido = Convert.ToInt32(Console.ReadLine());

        {

            if (EsPrimo(numeroIntroducido))
            {
                WriteLine("Es primo");
            }
            else
            {
                WriteLine("No es un número primo");
             
            }

        }

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
           
                    return false;
                }
            }

            return true;
        }


    }
}