using static System.Console;
namespace CursoCSharp_3_concatenar_cadena;

internal class Program
{
    static void Main(string[] args)
    {
        string superheroe = "Superman";
        string procedencia = "Kripton";
        string superpoder = " super fuerza";

        //Ejermplo 1
        string todosLosDatos = superheroe + " procede de " + procedencia + " y tiene " + superpoder;
        WriteLine(todosLosDatos);
        ReadLine();

        // Ejemplo 2

        string todosLosDatoConcat = string.Concat(superheroe, " procede de ", procedencia, " y tiene ", superpoder);
        WriteLine(todosLosDatoConcat);
        ReadLine();

        // Ejemplo 3 

        string todosLosDatosConcat2 = string.Concat(superheroe, superpoder);
        WriteLine(todosLosDatosConcat2);
        ReadLine();

        // Ejemplo 4

        string todosDatosInterpolation = $"{superheroe} procede de {procedencia} y tiene {superpoder}";
        WriteLine(todosDatosInterpolation);
        ReadLine();

        // Ejemplo 5

        string todosDatosInterpolation2 = $"{5+3 } es igual a 8 ?";
        WriteLine(todosDatosInterpolation2);
        ReadLine();
    }

}