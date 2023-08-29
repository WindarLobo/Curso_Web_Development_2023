using static System.Console;
namespace CursoCSharp_3_Paso_valor_referencia;

internal class Program
{
    static void Main(string[] args)
    {
        int numero1 = 25;
        int numero2 = 55;

        //WriteLine(numero1);
        // CambiarPorValor(numero1);
        //CambiarPorReferencia(ref numero1);
        Devuelve2ValoresPorReferencia(ref numero1, ref numero2);
        WriteLine(numero1 + " " + numero2 );

    }
    //Paso por valor
    public static void CambiarPorValor(int numero)
    {
        numero = 10;
    }
    //Paso por referencia
    public static void CambiarPorReferencia(ref int numero)
    {
        numero = 10;
    }
    //Funcion  que devuelve 2 valores
    public static void Devuelve2ValoresPorReferencia(ref int numero1,ref int numero2)
    {
        numero1 = 10;
        numero2 = 20;
    } 
}