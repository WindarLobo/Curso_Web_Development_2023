using System.Diagnostics;
using System.Text;
using static System.Console;
namespace Ejercicio_Cuatro;

internal class Program
{
    static void Main(string[] args)
    {
        /*Escribir un programa que pida 4 números por consola, y escriba la siguiente frase, "El primer numero introducido es el <numero1> ,
         * despues han introducido el <numero2> y <numero3> y por ultimo el <numero4>"  utilizar StringBuilder para realizar el ejercicio.*/

        //int contador = 0;
        //do
        //{

        //    WriteLine("Introduce el primer numero");
        //    string usuario1 = ReadLine();
        //    if (double.TryParse(usuario1, out double num1))
        //    {
        //        StringBuilder frases1 = new StringBuilder($"El primer numero introducido es el {num1}");
        //        WriteLine(frases1 + "\n");

        //        WriteLine("Introduce el segundo numero");
        //        string usuario2 = ReadLine();
        //        if (double.TryParse(usuario2, out double num2))
        //        {
        //            StringBuilder frases2 = new StringBuilder($"El segundo numero introducido es el {num2}");
        //            WriteLine(frases2 + "\n");


        //            WriteLine("Introduce el tercer numero");
        //            string usuario3 = ReadLine();
        //            if (double.TryParse(usuario3, out double num3))
        //            {
        //                StringBuilder frases3 = new StringBuilder($"El tercer numero introducido es el {num3}");

        //                WriteLine(frases3 + "\n");


        //                WriteLine("Introduce el cuarto numero");
        //                string usuario4 = ReadLine();
        //                if (double.TryParse(usuario4, out double num4))
        //                {
        //                    StringBuilder frases4 = new StringBuilder($"El cuarto numero introducido es el {num4}");
        //                    WriteLine(frases4);

        //                }

        //            }
        //        }
        //    }
        //    contador++;
        //    ReadLine();

        //} while (contador >= 4);

        StringBuilder frase = new StringBuilder();

        pedirNumero(frase, "primer");
        pedirNumero(frase, "segundo");
        pedirNumero(frase, "tercer");
        pedirNumero(frase, "cuarto");

        Console.WriteLine(frase.ToString());
    }

    private static void pedirNumero(StringBuilder frase, string ordinal)
    {
        Console.WriteLine($"Introduce el {ordinal} numero");
        string entrada = Console.ReadLine();

        if (double.TryParse(entrada, out double numero))
        {
            frase.Append($"El {ordinal} numero introducido es el {numero}, \n");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Introduce un número válido.");
            pedirNumero(frase, ordinal); // Reintenta la entrada.
        }
    }

}
