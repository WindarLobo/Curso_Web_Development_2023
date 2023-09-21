using System.Collections;
using static System.Console;
namespace Ejercicio_Cuatro;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa nos pida introducir 10 números enteros. 
         esos valores los introduciremos en un Listado y  mostraremos el numero mayor y menor, 
          consultando los valores en el Listado*/

        ArrayList listaDeNumeros = new ArrayList();

        int numero = 10;

        for (int i = 1; i <= numero; i++)
        {
            WriteLine($"Introduce el {i} numero : ");
            string usuario = ReadLine();

            if (int.TryParse(usuario, out int numeroUsuario))
            {
                listaDeNumeros.Add(numeroUsuario);
                listaDeNumeros.Sort();
                listaDeNumeros.Reverse();
            }

        }
        WriteLine($"\nMostraremos los  numeros de  mayor y menor :");
        ReadLine();
        foreach (int i in listaDeNumeros)
        {

            WriteLine(i);


        }
        ReadLine();
    }
}