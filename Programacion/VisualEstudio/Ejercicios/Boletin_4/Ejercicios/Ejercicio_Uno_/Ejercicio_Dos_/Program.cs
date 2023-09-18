using static System.Console;
namespace Ejercicio_Dos_;

internal class Program
{
    static void Main(string[] args)
    {
        /*Escribir un programa que pida una palabra, y la escriba a su inversa , por ejemplo si se introduce Paris, devolverá "Sirap".*/

        WriteLine("Introduce una palabra");

        string reversa = ReadLine();


        WriteLine($"Cadena al revés: {reversaPalabra(reversa)}");

    }

    private static string reversaPalabra(string reversa)
    {

        char[] rever = reversa.ToCharArray();

        Array.Reverse(rever);

        return new string(rever);


    }
}