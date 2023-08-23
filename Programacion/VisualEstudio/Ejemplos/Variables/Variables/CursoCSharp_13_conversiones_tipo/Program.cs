using static System.Console;
namespace CursoCSharp_13_conversiones_tipo;

internal class Program
{
    static void Main(string[] args)
    {
        //string cadena = "Hola";
        //int numero = 12;
        //cadena=numero.ToString();
        //WriteLine(cadena);

        //Implicitos
        int numeroEntero = 34543;
        long numerolong = numeroEntero;

        //Explicitos
        double numeroDouble = 12.56;
        int numeroEnteroDouble = (int)numeroDouble;
        WriteLine(numeroEnteroDouble);

        //Definidos por el usuario

        //Con clase de asistentes

    }
}