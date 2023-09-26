using System.Collections;
using System.Drawing;
using static System.Console;
namespace Ejercicio_Cinco;

internal class Program
{
    static void Main(string[] args)
    {
        /*Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, 
          dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos en el array. 
          una vez introducidos,
         nos pedirá un nuevo valor a insertar y la posición donde queremos insertarla en el array.*/
        do
        {

            WriteLine("Cuanto elemento quieres tener tu array");
            string lis = ReadLine();
            if (int.TryParse(lis, out int tamañoArrays) && tamañoArrays > 0)
            {

                int[] miArreglo = new int[tamañoArrays];

                for (int i = 0; i < tamañoArrays; i++)
                {
                    Write($"Ingrese el elemento {i + 1}: ");
                    string arreglo = ReadLine();

                    if (int.TryParse(arreglo, out int elemento))
                    {
                        miArreglo[i] = elemento;

                    }
                    else
                    {
                        WriteLine("Invalido, debes de ingresar un numero entero");
                        i--;
                    }
                }
                WriteLine("Elementos en el arreglo:");
                foreach (int elemento in miArreglo)
                {
                    WriteLine(elemento);
                   
                }
                break;

            }
            else
            {
                WriteLine("Error al introducir el elemento,debes de ingresar un numero entero ");
            }
          
        } while (true);
    }
}