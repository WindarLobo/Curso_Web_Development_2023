using static System.Console;
namespace Ejercicio_Catorce;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa calcule cuantas cifras tiene un número entero positivo
         (pista: se puede hacer dividiendo varias veces entre 10).*/

        int numero, contador;
        contador = 0;

        WriteLine("Introduce un número entero positivo: ");
        numero = Convert.ToInt32(ReadLine());

        while (numero > 0)
        {
            numero /= 10;

            contador++;
        }
        WriteLine("El número de digitos es {0}.", contador);

    }
}