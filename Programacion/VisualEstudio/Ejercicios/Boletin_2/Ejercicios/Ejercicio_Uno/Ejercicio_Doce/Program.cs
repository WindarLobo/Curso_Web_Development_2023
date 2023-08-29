using static System.Console;
namespace Ejercicio_Doce;

internal class Program
{
    static void Main(string[] args)
    {
        /* Crea un programa que pida por consola un numero del 1 al 1000 (validara que el numero introducido es correcto) 
         y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.*/


        WriteLine("Introduzca  un numero del 1 al 1000 :");
        int numeroSuma = 0;
        int usuario;
        while (true)
        {

            usuario = Convert.ToInt32(ReadLine());
            if (usuario >= 1 && usuario <= 1000)
            {
                break;
            }
            else
            {
                WriteLine("Numero invalido. introduce un numero del 1 al 1000");

            }
        }

        for (int i = 1; i <= usuario; i++)
        {
            numeroSuma += i;

         }
        double media = (double)numeroSuma /usuario;
        WriteLine("La suma es " + numeroSuma);
        WriteLine("La media  es " + media);
    }
}
        
    


