using static System.Console;
namespace Ejercicio_Ocho;

internal class Program
{
    static void Main(string[] args)
    {
        /* Recorre los números del 1 al 100.
         Muestra los números pares o divisibles entre 3 */

        int numero = 100;
        for (int i = 1; i < numero; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                WriteLine("El numero " + i + " es divisible");
            }
            else
            {
                WriteLine("El numero " + i + " no es divisible ");
            }

        }
    }
}