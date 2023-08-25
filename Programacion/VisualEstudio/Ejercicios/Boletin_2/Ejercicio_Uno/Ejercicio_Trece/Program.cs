using static System.Console;
namespace Ejercicio_Trece;

internal class Program
{
    static void Main(string[] args)
    {
        /* Comprobar si un numero introducido por consola es primo*/
        do
        {
            WriteLine("Introduce un numero");
            string usuario = ReadLine();

            if (int.TryParse(usuario, out int numeroIntroducido))
            {

                if (EsPrimo(numeroIntroducido))
                {
                    WriteLine("Es primo");
                   
                }
                else
                {
                    WriteLine("No es un número primo");

                }
                break;
            }
          
            else
            {
                WriteLine("Debes de introducir un numero \n");
            }
        }while(true);

        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
           
                    return false;
                }
            }

            return true;
        }


    }
}