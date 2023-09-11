using System;
using static System.Console;
namespace Ejercicio_Uno_;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro",
        o bien le diga "No te conozco" si teclea otro nombre.
        tener en cuenta, que el la validación no es case sensitive,
        es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.*/

        do
        {
            WriteLine("Introduce tu nombre");
            string nombre = ReadLine();


            if (ValidarNombre(nombre))
            {


                WriteLine($"Hola {nombre}");
                ReadLine();
                break;
            }
            else
            {
                WriteLine($"No te conozco {nombre}");
                ReadLine();
            }
        }while(true);
    }

    static bool ValidarNombre(string nombre)
    {
       
         nombre = nombre.ToLower();

       
        string nombreValido = "alejandro";

        return nombre == nombreValido;
    }
}






