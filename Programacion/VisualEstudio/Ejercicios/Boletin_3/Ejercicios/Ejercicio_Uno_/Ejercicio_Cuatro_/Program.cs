using static System.Console;
namespace Ejercicio_Cuatro_;

internal class Program
{


    static void Main(string[] args)
    {
        /* Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal,
         una cifra numérica o una consonante (realizar obligatoriamente 3 funciones, "EsNumero", "EsVocal", "EsConsonante").*/
        do
        {
            WriteLine("Introduce una letra  :");
            String usuario = ReadLine();

            if (char.TryParse(usuario, out char usuarioIntroducido))
            {
                if (EsVocal(usuarioIntroducido))
                {
                    WriteLine("Es una vocal");
                    break;
                }
                else if (EsNumero(usuarioIntroducido))
                {
                    WriteLine("Es un nuemro");
                    break;
                }
                else if (EsConsonante(usuarioIntroducido))
                {
                    WriteLine("Es consonate");
                    break;
                }
                else
                {
                    WriteLine("No es  un numero ,ni vocal, ni consonante");
                }



            }
        } while (true);
    }

    private static bool EsVocal(char esVocal)
    {
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        char charLowerCase = Char.ToLower(esVocal);
        return Array.Exists(vocales, vocal => vocal == charLowerCase);
    }
    private static bool EsNumero(char esNumero)
    {
        if (Char.IsDigit(esNumero))
        {
            return true;

        }
        return false;
    }

    private static bool EsConsonante(char esConsonante)
    {
        char[] consonante = { 'a', 'b', 'c', 'd', 'e', 'f', 'G', 'H', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        char charLowerCase = Char.ToLower(esConsonante);
        return Array.Exists(consonante, consonante => consonante == charLowerCase);
    }



}