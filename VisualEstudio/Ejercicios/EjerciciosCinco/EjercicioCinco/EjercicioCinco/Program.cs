namespace EjercicioCinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pedir por consola un nombre de persona
            y el nombre de una ciudad (no hace falta que sean reales o comprobarlos)
            y mostrar por pantalla, el siguiente mensaje “Hola ” <nombre> ” bienvenido a ” <ciudad>*/

            var nombrePersona = ("Introduzca su nombre");
            Console.WriteLine(nombrePersona);
            nombrePersona = Console.ReadLine();

            var nombreCiudad = ("Introduzca la ciudad");
            Console.WriteLine(nombreCiudad);
            nombreCiudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombrePersona + ", bienvenido a " + nombreCiudad + " =)");
            Console.ReadKey();
        }
    }
}