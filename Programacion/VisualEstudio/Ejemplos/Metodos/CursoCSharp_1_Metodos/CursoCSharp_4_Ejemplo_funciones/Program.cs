using System.Net.NetworkInformation;
using static System.Console;
namespace CursoCSharp_5_Ejemplo_funciones;

internal class Program
{
    static void Main(string[] args)
    {
        var  opciones = PintaMenu();

        while (opciones != "5")
        {
            EjecutarOpciones(opciones);
            opciones = PintaMenu();

        }
    }
    public static string PintaMenu()
    {
        WriteLine("**** Menu ****");
        WriteLine("**** 1. Suma ****");
        WriteLine("**** 2. Resta ****");
        WriteLine("**** 3. Multiplicacion ****");
        WriteLine("**** 4. Mi operacion ****");
        WriteLine("**** 5. Salir ****");

        return ReadLine();
    }
    public static void EjecutarOpciones(String opcion)
    {
        switch(opcion)
        {
            case "1":

                WriteLine(Suma(1, 7));
                break;
            case "2":
                WriteLine(Resta(15, 9));
                break;
            case "3":
                WriteLine(Multiplicacion(10, 3));
                break;
            case "4":
                WriteLine(MiOperacion(5, 2));
                break;
            case "5":
                WriteLine("Salir");
                break;
        }
    }

    public static int Suma(int num1,int num2)
    {
        return num1 + num2;
    }
    public static int Resta(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Multiplicacion(int num1, int num2)
    {
        return num1 * num2;
    }


    public static int MiOperacion(int num1, int num2)
    {
        var suma = Suma(num1 , num2);
        var resta = Resta(suma, num2);
        var multipliacion = Multiplicacion(resta, num2);
        return resta;
    }

}