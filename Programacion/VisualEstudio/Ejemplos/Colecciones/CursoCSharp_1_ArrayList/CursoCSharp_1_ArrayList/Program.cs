using System.Collections;
using static System.Console;
namespace CursoCSharp_1_ArrayList;

internal class Program
{
    static void Main(string[] args)
    {
      //ArrayList

        ArrayList lista = new ArrayList();
        lista.Add(1);
        lista.Add("Batman");

        //foreach (var item in lista)
        //{
        //    WriteLine(item);
        //}
        //ReadLine();

        //var elemento = lista[0];
        //var elemento1 = lista[1];
        //WriteLine(elemento1);
        //ReadLine();

        //int contador = lista.Count;

        //WriteLine("Contador :" + contador + "\n");

        lista.Insert(1, "Superman");
        foreach (var item in lista)
        {
            WriteLine(item);
     
        }
        ReadLine();
        lista.RemoveAt(1);
        foreach (var item in lista)
        { WriteLine(item); }    

    }
}