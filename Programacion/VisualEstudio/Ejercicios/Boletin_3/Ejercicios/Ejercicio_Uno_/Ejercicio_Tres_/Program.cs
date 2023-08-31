using System.Runtime.CompilerServices;
using static System.Console;
namespace Ejercicio_Tres_;

internal class Program
{
    private const int billete500 = 500, billete200 = 200, billete100 = 100,
        billete50 = 50, billete20 = 20, billete10 = 10, billete5 = 5, moneda2 = 2, moneda1 = 1;


    private static int cantidad500, cantidad200, cantidad100, cantidad50, cantidad20, cantidad10, cantidad5, cantidad2, cantidad1 = 0;


    static void Main(string[] args)
    {
        /*Se creara un programa que mediante funciones, nos ayude a desglosar
          un importe introducido por consola, en el numero mínimo posible de billetes y monedas.*/
        try
        {
            contadorDeBilletesYMonedas();

            WriteLine("Billete de 500 : " + cantidad500);
            WriteLine("Billete de 200 : " + cantidad200);
            WriteLine("Billete de 100 : " + cantidad100);
            WriteLine("Billete de 50 : " + cantidad50);
            WriteLine("Billete de 20 : " + cantidad20);
            WriteLine("Billete de 10 : " + cantidad10);
            WriteLine("Billete de 5 : " + cantidad5);
            WriteLine("Moneda de 2 : " + cantidad2);
            WriteLine("Moneda de 1 : " + cantidad1);

        }
        catch (Exception ex)
        {
            WriteLine(ex.GetType);
        }



        ReadLine();


    }
    private static int contadorDeBilletesYMonedas()
    {
        do
        {

            WriteLine("Introduce un importe :");

            String importeIntroducido = ReadLine();

            if (int.TryParse(importeIntroducido, out int montoTotal))
            {
                while (montoTotal > 0)
                {
                    if (montoTotal >= billete500)
                    {
                        cantidad500++;
                        montoTotal -= billete500;

                    }
                    else if (montoTotal >= billete200)
                    {
                        cantidad200++;
                        montoTotal -= billete200;

                    }
                    else if (montoTotal >= billete100)
                    {
                        cantidad100++;
                        montoTotal -= billete100;

                    }
                    else if (montoTotal >= billete50)
                    {
                        cantidad50++;
                        montoTotal -= billete50;

                    }
                    else if (montoTotal >= billete20)
                    {
                        cantidad20++;
                        montoTotal -= billete20;

                    }
                    else if (montoTotal >= billete10)
                    {
                        cantidad10++;
                        montoTotal -= billete10;
                    }
                    else if (montoTotal >= billete5)
                    {
                        cantidad5++;
                        montoTotal -= billete5;
                    }
                    else if (montoTotal >= moneda2)
                    {
                        cantidad2++;
                        montoTotal -= moneda2;
                    }
                    else if (montoTotal >= moneda1)
                    {
                        cantidad1++;
                        montoTotal -= moneda1;

                    }


                }
                return montoTotal;

            }
            else
            {
                WriteLine("Error al introducir. Por favor, ingresa un número válido.\n");
            }



        } while (true);
    }

}

