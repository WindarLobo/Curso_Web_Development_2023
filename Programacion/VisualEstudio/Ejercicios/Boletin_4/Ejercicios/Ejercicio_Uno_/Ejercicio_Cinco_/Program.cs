using static System.Console;
namespace Ejercicio_Cinco_;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)*/

        char letra = 'Z'; // Comienza con la letra 'z'

        while (letra >= 'A')
        {
            WriteLine(letra);
            letra--;
        }
    }
}