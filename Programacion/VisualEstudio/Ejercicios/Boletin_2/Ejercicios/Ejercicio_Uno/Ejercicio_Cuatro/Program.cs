using static System.Console;
namespace Ejercicio_Cuatro;

internal class Program
{
    private static int precio;

    static void Main(string[] args)
    {
        /*Pedir al usuario el precio de un producto (valor positivo)
          y la forma de pagar (efectivo o tarjeta) si la forma de pago 
          es mediante tarjeta, pedir el numero de cuenta (inventado).*/

        do
        {
            WriteLine("introduzca el precio del producto");

            string usuario = ReadLine();


            if (int.TryParse(usuario, out int precio))
            {

                if (precio > 0)
                {
                    WriteLine("Forma de pago (Tarjeta o efectivo)");

                    string formaDePago = ReadLine();

                    string pagoConTarjeta = formaDePago;

                    switch (formaDePago.ToLower())
                    {
                        case "tarjeta":

                            pagoConTarjeta = "tarejta";
                            WriteLine(" Introduzca el numero de cuenta : ");
                            string numeroDeCuenta = ReadLine();
                            WriteLine("\n El numero de cuenta es :" + numeroDeCuenta + " el total al pagar es  : " + precio);
                            break;

                        case "efectivo":
                            pagoConTarjeta = "efectivo";
                            WriteLine("Pago con efectivo !! \n" + "El total es : " + precio);
                            break;

                        default:
                            WriteLine("Error");
                            break;
                    }

                    break;
                }
                else
                {
                    WriteLine("El precio no puede ser negativo \n");
                 
                }
            }

        } while (true);

        ReadLine();

    }

    }
