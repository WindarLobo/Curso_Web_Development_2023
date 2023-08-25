using static System.Console;
namespace Ejercicio_Nueve;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crea un array e inserta los números pares del 1 al 100 en ese array*/

        int[] numero = new int[100];



        for (int i = 0; i < numero.Length; i++)
        {
            numero[i] = i + 1;
            WriteLine(numero[i]);

        }

    }
}
