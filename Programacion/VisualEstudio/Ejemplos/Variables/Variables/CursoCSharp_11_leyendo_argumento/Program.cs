using static System.Console;

namespace CursoCSharp_11_leyendo_argumento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Hay " + args.Length + " elementos");
            foreach (var argumentos in args)

            {
                WriteLine($"{argumentos}");
            }
        }
    }
}