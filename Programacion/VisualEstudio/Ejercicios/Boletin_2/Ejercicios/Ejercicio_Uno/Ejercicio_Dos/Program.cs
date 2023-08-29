using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Dos;

internal class Program
{
    static void Main(string[] args)
    {
        /* Pedir dos números al usuario por teclado y decir que número es el mayor.*/


        Console.WriteLine("Introduzca el primer número:");
        string inputNumeroUno = ReadLine(); // Lee la entrada del usuario como una cadena

        // Intenta convertir la entrada en un número entero

        if (int.TryParse(inputNumeroUno, out int numeroUno))
        {
            // La conversión fue exitosa
            Console.WriteLine("El primer número es: " + numeroUno + "\n");
        }
        Console.WriteLine(" Introduzca el segundo número:" + "\n");
        string inputNumeroDos = ReadLine();
        if(int.TryParse(inputNumeroDos, out int numeroDos))
        {
            Console.WriteLine("El segundo  numero es : " + numeroDos + "\n");
        }

        if (numeroUno > numeroDos){
            WriteLine("El numero " + numeroUno + " es mayor que el numero " + numeroDos);
        }
        else
        {
            WriteLine("El numero " + numeroDos + " es mayor que el numero " + numeroUno);
        }

    }
}