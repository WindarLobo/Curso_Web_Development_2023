using System.Collections;
using System.Reflection.PortableExecutable;
using static System.Console;
namespace CursoCSharp_4_hastable;

internal class Program
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();

        //Añadir valores
        hashtable.Add("Alejandro", 1.22);
        hashtable.Add("Rodrigo", 5.21);
        hashtable.Add("Miriam", 9.62);

        //Recorriendo hastable
        foreach (DictionaryEntry item in hashtable)
        {

            WriteLine(item.Value + " " + item.Key);

        }

        //Obtener el valor del hastable
        var valor = hashtable["Alejandro"];
        WriteLine(valor);
        ReadLine();

        //Contar elemetos
        var cuantosElementos = hashtable.Count;
        WriteLine(cuantosElementos);
        ReadLine();

        //Buscar
        if (hashtable.ContainsKey("Alejandro"))
        {

        }
        if (hashtable.ContainsValue(9.62))
        {

        }
        //Eliminar

        hashtable.Remove("Alejandro");



        //Recorremos hastable
        foreach (DictionaryEntry item in hashtable)
        {
            WriteLine(item.Value + " " + item.Key);
        }

        //Eliminar
        hashtable.Clear();

        foreach (DictionaryEntry item in hashtable)
        {
            WriteLine(item.Value + " " + item.Key);
        }
        ReadLine();            

    }
}