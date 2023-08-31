using static System.Console;
namespace Ejercicio_Seis_;

internal class Program
{
     
   private static int numero;
    private static int cantidadNumeros = 0;
    private  static int numeroMasAlto = int.MinValue;
    private static int numeroMasBajo = int.MaxValue;

    static int numeroCero;

    static void Main(string[] args)
    {
        /*Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. una vez pulsado el 0 se mostrara la siguiente información:

        numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos

        Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0.*/

        WriteLine("Introduce números por consola. Pulsa 0 para finalizar.\n");

        do
        {

            pedirNumero();


        } while (numero != 0);


    }
    private static void pedirNumero()

    {
   

        bool esNumeroValido = false;

        while (!esNumeroValido)
        {
           Write("Introduce un número: ");

            string numeroIntroducido = ReadLine();


            if (int.TryParse(numeroIntroducido, out numero))
            {
                if (numero != 0)
                {
                    cantidadNumeros++;

                    if (numero > numeroMasAlto)
                    {
                        numeroMasAlto = numero;
                    }

                    if (numero < numeroMasBajo)
                    {
                        numeroMasBajo = numero;
                    }

                   
                    esNumeroValido = true;


                }
                else
                {
                    WriteLine("\nNúmero 0 detectado." + "\nFinalizando entrada de números.\n");

                    WriteLine("\nNúmero más alto: " + numeroMasAlto);

                    WriteLine("Número más bajo: " + numeroMasBajo);

                    WriteLine("Diferencia entre el mayor y el menor: " + (numeroMasAlto - numeroMasBajo));

                    WriteLine("Cantidad de números introducidos: " + cantidadNumeros);


                    numero = 0;
                    break;

                }

                }

            else
            {
                WriteLine("No es un número válido. Inténtalo de nuevo.");


            }


        }

    }


}









