using System.Diagnostics;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Tres_;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola y se muestre la siguiente información de esa cadena (usa funciones para cada caso) ,
         se deberá validar que la cadena tiene al menos 20 caracteres y la frase consta al menos de 4 palabras

*longitud de la cadena

*pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" se cambiara por una "x" y si es "A" se cambiara por una "X"

*pinta la cadena en mayúsculas

*pinta la cadena en minúsculas

*pinta la cadena, removiendo las 3 primeras letras

*pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10

*invierte la cadena

*escribe el numero de palabras que tiene la frase

*escribe únicamente la tercera palabra*/


        string datos;
        do
        {
            WriteLine("Por favor, ingresa una frase de al menos 20 caracteres y al menos 4 palabras:");
            datos = ReadLine();
        } while (!ValidarFrase($"{datos}"));


        remplazandoCadena(datos);
        palabraEnMayuscula(datos);
        palabraEnMinunuscula(datos);
        removerPalabra(datos);
        extrayendoCadena(datos);
        palabraInvertida(datos);
    }


    private static bool ValidarFrase(string frase)
    {
        // Verificar la longitud mínima de la cadena
        if (frase.Length < 20)
        {
            WriteLine("La frase debe tener al menos 20 caracteres.");
            return false;
        }

        // Dividir la cadena en palabras
        string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Verificar la cantidad mínima de palabras
        if (palabras.Length < 4)
        {
            WriteLine("\nLa frase debe contener al menos 4 palabras.");
            return false;
        }

        WriteLine($"La frase ingresada es:{frase}");
        palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        WriteLine($"\nNúmero de palabras:{palabras.Length}");

        // Mostrar las palabras individualmente
        WriteLine("\nPalabras en la frase:");
        foreach (string palabra in palabras)
        {
            WriteLine(palabra);

        }
        return true;


    }

    private static void remplazandoCadena(string palabra)
    {

        palabra = palabra.Replace("a", "x").Replace("A", "X");
        WriteLine($"\nFrase después del reemplazo:\n{palabra}");
        ReadLine();

    }

    private static void palabraEnMayuscula(string palabra)
    {
        string palabraMayuscula = palabra.ToUpper();
        WriteLine($"\nPalabra en mayuscula:\n{palabraMayuscula}");
        ReadLine();

    }
    private static void palabraEnMinunuscula(string palabra)
    {
        string palabraMinuscula = palabra.ToLower();
        WriteLine($"\nPalabra en minuscula:\n{palabraMinuscula}");
        ReadLine();

    }

    private static void removerPalabra(string palabra)
    {


        palabra = palabra.Remove(0, 3);
        WriteLine($"\nEliminamos las 3 primeras palabras:\n {palabra}");
        ReadLine();

    }
    private static void extrayendoCadena(string palabra)
    {
        if (palabra.Length >= 10)
        {

            WriteLine(palabra);
            string subcadena = palabra.Substring(4, 6);
            WriteLine(subcadena);
            ReadLine();
        }
        else
        {
            WriteLine(" ");
        }

    }
    private static void palabraInvertida(string palabra)
    {
        char[] charArray = palabra.ToCharArray();
        Array.Reverse(charArray);
        WriteLine(charArray);

    }



}
