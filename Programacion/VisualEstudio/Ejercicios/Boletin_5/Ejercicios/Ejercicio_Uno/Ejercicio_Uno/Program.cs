using System.Collections;
using static System.Console;
namespace Ejercicio_Uno;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa, que recorra con un bucle for del 1 al 1000, 
          insertando en cada iteración el valor del numero en un ArrayList. 
          una vez acabe el proceso , recorreremos ese ArrayList mostrando 
          en consola la suma de los números  , ejemplo: 1, 3, 6, 10.*/

        ArrayList numerosInsertados = new ArrayList();

        int numero = 100, suma = 0;

        for (int i = 1; i <= numero; i++)
        {
            numerosInsertados.Add(i);
        }

        foreach (int item in numerosInsertados)
        {

            WriteLine($"La suma es : { suma += item}");
        }
        ReadLine();

    }
}