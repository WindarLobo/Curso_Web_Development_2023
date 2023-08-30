using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Cinco_;

internal class Program
{
    private static int resultado;

    private static int numero = 10;

    static void Main(string[] args)
    {
        /*Crear un programa usando funciones, que introduciendo un número por consola, pinte su tabla de multiplicar en la consola.*/
     
            tablaDeMultiplicar();
        ReadLine();

    }
    private static void tablaDeMultiplicar()
    {

        do
        {

            WriteLine("Introduce un numero");

            string multiplicar = ReadLine();

            if (int.TryParse(multiplicar, out int tablaDeMultiplicar))
            {
                while (tablaDeMultiplicar > 0)
                {
                    for (int i = 1; i <= numero; i++)
                    {
                        resultado = tablaDeMultiplicar * i;

                        WriteLine(tablaDeMultiplicar + " X " + i + " : " + resultado + "\n");

                    }
                    break;

                }
                break;

            }
            else
            {
                WriteLine("Debes introducir un número válido.\n");


            }

        } while (true);
    }
}