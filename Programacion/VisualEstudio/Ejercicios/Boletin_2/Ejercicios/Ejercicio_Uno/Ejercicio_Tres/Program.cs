using static System.Console;
namespace Ejercicio_tres;

internal class Program
{
    static void Main(string[] args)
    {
        /* Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo*/

        do
        {
            WriteLine("Introduzca  un dia de la semana (Lunes, Martes, Miércoles, Jueves, Viernes, Sábado o Domingo):");

            string usuario = ReadLine();

            String nombreDelDia = usuario.ToLower();


            if (nombreDelDia == "lunes" || nombreDelDia == "martes" || nombreDelDia == "miercoles" || nombreDelDia == "jueves" || nombreDelDia == "viernes")
            {
                WriteLine("No es fin  de semana");
                break;


            }

            else if (nombreDelDia == "sabado" || nombreDelDia == "domingo")
            {
                WriteLine("Fin  de semana");
                break;

            }
            else
            {
                WriteLine("Dia de la semana no existe");
            }
        } while (true);

        ReadLine();



    }
}