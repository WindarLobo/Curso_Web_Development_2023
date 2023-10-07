namespace CursoCSharp_5_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clases clases = new Clases();
            clases.Calcular(27);


            Console.WriteLine(clases.sumar(1,6));
            Console.ReadLine();

        }
    }
}