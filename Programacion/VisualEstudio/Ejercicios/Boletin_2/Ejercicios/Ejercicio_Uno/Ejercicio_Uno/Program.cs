using static System.Console;
namespace Ejercicio_Uno;

internal class Program
{
    static void Main(string[] args)
    {
        /*Crear 3 variables numéricas con el valor que tu quieras
        y en otra variable numérica guardar el valor de la suma de las 3 anteriores.
        Mostrar por consola.*/

        int numeroUno = 15;
        int numeroDos = 25;
        int numeroTres = 100;

        int  numeroSuma = numeroUno + numeroDos + numeroTres;
        WriteLine("La suma es : " + numeroSuma);
    }
}