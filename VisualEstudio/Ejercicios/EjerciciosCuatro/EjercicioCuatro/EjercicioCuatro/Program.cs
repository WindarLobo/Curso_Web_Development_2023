namespace EjercicioCuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En el proyecto del punto 1, pide por consola que el usuario introduzca su nombre y muestra "Hola, <nombre>"

            var nombre = ("Introduce tu nombre");
            Console.WriteLine(nombre);
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();



        }
    }
}