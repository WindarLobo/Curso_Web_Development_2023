using System.Collections;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Dos;

internal class Program
{
    static void Main(string[] args)
    {

        ArrayList listaDeNombre = new ArrayList();

        /*Pedir por pantalla 5 nombres, e insertarlo en una Lista (List)
          una vez insertados, se pedirá que introduzcamos un nombre, 
          el programa tendrá que decirnos, si ese nombre esta contenido en la lista.*/
        do
        {
            nombreT(listaDeNombre);
            comprobacionDeNombre(listaDeNombre);
            break;
        } while (true);

    }
    private static void nombreT(ArrayList listaDeNombre)
    {
        int numero = 5;

        for (int i = 1; i <= numero; i++)
        {
            WriteLine($"Introduce el {i} nombre: ");
            string nombre = ReadLine();
            listaDeNombre.Add(nombre.ToLower());
        }

    }
    private static string comprobacionDeNombre(ArrayList listaDeNombre)
    {

        WriteLine($"\nIntroduce un nombre para comprobar si esta en la lista: ");
        string nombreConten = ReadLine();
        if (listaDeNombre.Contains(nombreConten.ToLower()))
        {
            WriteLine($"El nombre {nombreConten} si esta en la lista");
            ReadLine();

        }
        else
        {
            WriteLine($"El nombre {nombreConten} no existe ");
            ReadLine();

        }

        return nombreConten;
    }

}
