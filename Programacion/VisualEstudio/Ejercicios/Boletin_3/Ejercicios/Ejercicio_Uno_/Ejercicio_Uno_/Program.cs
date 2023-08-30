using System.Net.NetworkInformation;
using static System.Console;
namespace Ejercicio_Uno_;

internal class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que transforme entre dólares
        // y euros y que también pida el tipo de cambio del día.

        BancoDeCambio();
       
    }

    private static void BancoDeCambio()
    {
        do {

            WriteLine("Que quieres cambiar: \nDolar\nEuro");
            string tipoDeMoneda = ReadLine();

            switch (tipoDeMoneda.ToLower())

            {
                case "dolar":

                    WriteLine("El toal de dolar a euro es : " + ConversorDeCambio());
                    break;

                case "euro":
                    WriteLine("El tipo de cambio de euro a dolar es :  " + ConversorDeCambio());
                    break;

                default:
                    Console.WriteLine("Moneda no válida");
                    break;
            }

            double ConversorDeCambio()

            {
                double cantidad = 0;
                double cambio = 0;

                WriteLine("Introduce la cantidad: ");
                string introducirCantidad = ReadLine();

                if (double.TryParse(introducirCantidad, out cantidad))
                {
                    WriteLine("Tipo de cambio: ");
                    string usuario = ReadLine();

                    if (double.TryParse(usuario, out cambio))
                    {

                        return cambio * cantidad;
                    }
                    else
                    {
                        Console.WriteLine("Tipo de cambio no válido");
                    }
                }
                else
                {
                    Console.WriteLine("Cantidad no válida");
                }

                return 0;
            }

        } while (true);
    }
        
}

    
