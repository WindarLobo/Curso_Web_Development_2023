using static System.Console;

namespace CursoCSharp_5_operaciones_cadenas;

internal class Program
{
    static void Main(string[] args)
    {
        string villano = "Gru";
        string esbirros = "minions";
        string frase = "Los Minions ayudan a Gru a conquistar el mundo";


        //Concatenar cadenas

        string concatenar = String.Concat($"{villano} tiene, {esbirros}");
        WriteLine(concatenar);
        ReadLine();

        // Encontrar cadena
        if (villano.Contains("Gru"))
        {

        }
        if (esbirros.Contains("Mini"))
        {

        }

        //Obtener subcadena
        string subcadena = frase.Substring(4, 7); // cuebta hasta la posicion 4 y concatena 7 palabras
        WriteLine(subcadena);
        ReadLine();

        //Una cedena acaba en ....
        if (frase.EndsWith("mundo"))//  endswith es si esta la palabra 
        {

        }

        //Insertar una cedena en otra

        frase = frase.Insert(3, " adorables");
        WriteLine(frase);
        ReadLine();

        //Encontrar posicion d euna cedena
        var posicion = frase.LastIndexOf("mundo");
        frase = frase.Insert(posicion, "enorme ");
        WriteLine(frase);
        ReadLine();

        //borrar cadena
        var posicion2 = frase.LastIndexOf("enorme ");
        frase = frase.Remove(posicion2, 7);
        WriteLine(frase);
        ReadLine();

        //Replazar cadena

        frase = frase.Replace(" mundo", " luna");
        WriteLine(frase);
        ReadLine();

        // Dividir cadena 
        var palabras = frase.Split(' ');

        foreach (var palabra in palabras)
        {
            WriteLine(palabra);

        }
        ReadLine();


        // Pasar de mayuscula a minuscula

        string GRU = villano.ToUpper();
        string esbirro2 = esbirros.ToLower();

        WriteLine(GRU);
        WriteLine(esbirro2);
        ReadLine();

        //Por cadenas

        string espacionDelanteros = "  palabra";
        string espacionTrasero = "palabras ";
        string espacios = "  palabras ";

        WriteLine(espacionDelanteros.TrimStart());
        WriteLine(espacionTrasero.TrimEnd());
        WriteLine(espacios.Trim());
        ReadLine();



    }
}