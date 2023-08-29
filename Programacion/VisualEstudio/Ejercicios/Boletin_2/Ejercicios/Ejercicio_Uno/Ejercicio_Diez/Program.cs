using static System.Console;
namespace Ejercicio_Diez;

internal class Program
{
    static void Main(string[] args)
    {
        /*Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.*/

        int sumaPares = 0;
        int restaImpares = 0;

        for (int i = 1; i <= 10; i++)
        {
           
            Write($"Ingrese el número {i}: ");
            int numero = Convert.ToInt32(ReadLine());

            if (numero % 2 == 0)
            {

                sumaPares += numero;
                WriteLine(sumaPares + "\n");
            }
            else
            {
                {
                    restaImpares -= numero;
                    WriteLine(restaImpares + "\n");
                }
            }


        }
    }
   
        }

