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

        int contador = 0;
        do
        {

            WriteLine("Introduce el primer numero");
            string usuario1 = ReadLine();
            if (double.TryParse(usuario1, out double num1))
            {
                StringBuilder frases1 = new StringBuilder($"El primer numero introducido es el {num1}");
                WriteLine(frases1 + "\n");
                ReadLine();

                WriteLine("Introduce el segundo numero");
                string usuario2 = ReadLine();

                WriteLine("Introduce el tercer numero");
                string usuario4 = ReadLine();

                WriteLine("Introduce el cuarto numero");
                string usuario3 = ReadLine();

                if (double.TryParse(usuario4, out double num4))
                {

                    if (double.TryParse(usuario3, out double num3))
                    {

                        if (double.TryParse(usuario2, out double num2))
                        {
                            StringBuilder frases2 = new StringBuilder($"despues han introducido el  segundo nuemro:{num2}  el tercer numero: {num3} y por ultimo el cuarto numero: {num4}");
                            WriteLine(frases2 + "\n");

                        }

                    }
                }
            }
            contador++;
            ReadLine();

        } while (contador >= 4);

    }

}
