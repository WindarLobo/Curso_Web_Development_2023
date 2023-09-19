using System.Collections;
using static System.Console;
namespace CursoCSharp_2_pila;

internal class Program
{
    static void Main(string[] args)
    {
        //LIFO last in first out-->primero que entra,ultimo que sale

        Stack pila = new Stack();
        pila.Push(1);
        pila.Push(5);
        pila.Push(10);
        pila.Push(3);

        //3-->10-->5-->1

        var numero = pila.Pop();
        WriteLine(numero);

        foreach (var item in pila)
        {
            WriteLine(item);
        }
        ReadLine();
        // contador de elementos
        int contador = pila.Count;
        WriteLine("Contador de elementos " + contador);

        //Limpiar pila

        pila.Clear();

        if (pila.Contains(10))
        {
            WriteLine("Contiene un 10");
            ReadLine();

        }
    }
}