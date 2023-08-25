using static System.Console;
namespace Ejercicio_Siete;

internal class Program
{
    static void Main(string[] args)
    {
        /* Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.*/


        int numero = 100;
        for (int i = 1; i <= numero; i++)
        {
            if(i % 2 == 0)
            {
                WriteLine("El numero " + i + " es par");
            }
            else
            {
                WriteLine("El nuemro " + i + " no es par");
            }

        }
    }
}