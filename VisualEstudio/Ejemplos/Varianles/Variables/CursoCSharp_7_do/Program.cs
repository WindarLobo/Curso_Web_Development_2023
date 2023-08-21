namespace CursoCSharp_7_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero =0;
            do
            {
                Console.WriteLine(numero);
                numero++;
                if (numero == 5)
                {
                    return;
                }
            } while (numero<10);
        }
    }
}