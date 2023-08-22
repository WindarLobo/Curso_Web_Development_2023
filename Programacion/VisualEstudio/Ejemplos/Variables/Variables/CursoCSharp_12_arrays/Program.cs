using static System.Console;

namespace CursoCSharp_12_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type[] nombreArray;
            int[] arrayDeEnteros;
            int[] arrayDeEntero2 = new int[5];
            int[] arrayDeEnteros3 = { 1, 2, 3, 4 };
            int[,] arrayDeEnteros2Dimensiones = new int[2, 2];
            int[,] arraysDeEntero2Dimensiones2 = { { 2, 2 }, { 3, 6 } };
            int[][] arraysDeEnterosEscalonados = new int[6][];
            arraysDeEnterosEscalonados[0] = new int[4] { 3, 6, 7, 2 };
            arraysDeEnterosEscalonados[1] = new int[2] { 1, 3 };



            for (int i = 0; i < arrayDeEnteros3.Length; i++)
            {
                WriteLine(arrayDeEnteros3[i]);
            }
            foreach (var elementos in arrayDeEnteros3)
            {
                WriteLine(elementos);
            }
            for (int i = 0; i < arraysDeEntero2Dimensiones2.GetLongLength(0); i++)
            {
                for (int x = 0; x < arraysDeEntero2Dimensiones2.GetLongLength(1); x++)
                {
                    WriteLine(arraysDeEntero2Dimensiones2[i, x]);
                }
            }
            for (int i = 0; i < arraysDeEnterosEscalonados.GetLongLength(0); i++)
            {
                for (int x = 0; x < arraysDeEnterosEscalonados.GetLongLength(1); x++)
                {
                    WriteLine(arraysDeEnterosEscalonados[i][x]);
                }
            }


        }
    }
}
