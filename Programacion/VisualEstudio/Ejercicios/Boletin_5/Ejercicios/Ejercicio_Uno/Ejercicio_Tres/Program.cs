using System.Collections;
using static System.Console;
namespace Ejercicio_Tres;

internal class Program
{
    static void Main(string[] args)
    {
        /*Pedir por pantalla 10 números, que iremos almacenando en un Listado (o 2 como prefiramos). 
          al terminar de introducir los números, tendremos que recorrer el/los listados, 
          diciéndonos cuanto suman los pares y cuando los impares.*/

        ArrayList listaDeNumero = new ArrayList();

        int sumaPar = 0, sumaImpar = 0;

        for (int i = 1; i <= 10; i++)
        {
            bool entradaValida = false;
            int numeroIntroducido;

            do
            {
                WriteLine($"Introduce el {i} numero: ");
                string numeroUsuario = ReadLine();

                if (int.TryParse(numeroUsuario, out numeroIntroducido))
                {
                    listaDeNumero.Add(numeroIntroducido);
                    entradaValida = true;
                }
                else
                {
                    WriteLine("Entrada inválida. Por favor, introduce un número.");
                }
            } while (!entradaValida);
        }
        foreach (int numeroTotal in listaDeNumero)
        {
            if ((numeroTotal % 2) == 0)
            {
                sumaPar += numeroTotal;
            }

            else
            {

                sumaImpar += numeroTotal;

            }

        }
        WriteLine($"\nLos pares suman :  {sumaPar}");
        WriteLine($"Los  impares suman :  {sumaImpar}");
        ReadLine();
    }
}

