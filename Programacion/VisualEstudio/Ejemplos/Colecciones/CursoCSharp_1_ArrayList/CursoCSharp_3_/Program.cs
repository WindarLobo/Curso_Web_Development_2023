using System.Collections;
using static System.Console;

namespace CursoCSharp_3_;

internal class Program
{
    static void Main(string[] args)
    {
       //FIFO --> First In First Out --> sale el primero que entra

        Queue cola = new Queue();
        cola.Enqueue(3);
        cola.Enqueue(5);
        cola.Enqueue(1);

        //Extraer valores de la cola
        var valorCola= cola.Dequeue();
        WriteLine(valorCola);
        ReadLine();

        valorCola=cola.Dequeue();
        WriteLine(valorCola);
        ReadLine();   

        //Para observar el valor
        var valor = cola.Peek();
        WriteLine(valor);
        ReadLine();

        //Comprobar si existe un valor 
        if (cola.Contains(5))
        {
            //codigo
        }
        //Borrar
        cola.Clear();



        cola.Enqueue(13);
        cola.Enqueue(15);

        //conocer los elementos  que hay en la cola 
        int elementos = cola.Count;
        // recorrer la cola /
        foreach(var item in cola)
        {
            WriteLine(item);
        }
        ReadLine();
    }
}