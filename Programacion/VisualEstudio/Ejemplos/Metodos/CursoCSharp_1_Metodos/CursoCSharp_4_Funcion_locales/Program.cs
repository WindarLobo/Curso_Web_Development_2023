using static System.Console;
namespace CursoCSharp_4_Funcion_locales;

internal class Program
{
    static void Main(string[] args)
    {
        FuncionPrincipal(15);
        EjemploFuncional();
    }
    public static void FuncionPrincipal(int numero)
    {
        WriteLine("Estamos dentro de la funcion principal " + numero);

        numero += 10;
        FuncionLocal(numero);

        void FuncionLocal(int numeroLocal)
        {
            numeroLocal *= 15;
            WriteLine(numeroLocal);

        }
    }
    public static void EjemploFuncional()
    {
        int total = 0;
        List<int> lista = new List<int>();
        lista.Add(4);
        lista.Add(5);
        lista.Add(17);

        foreach (int numero in lista)
        {
            total=Sum(total, numero);
            WriteLine(total);

        }
        int Sum(int numero,int totalSuma)
        {
            return numero+totalSuma;
        }

    }

    }
