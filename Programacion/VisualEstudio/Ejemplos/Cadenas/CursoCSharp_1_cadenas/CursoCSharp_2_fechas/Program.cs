using static System.Console;
namespace CursoCSharp_2_fechas;

internal class Program
{
    static void Main(string[] args)
    {
        //DateTime fecha = new DateTime();
        //fecha=DateTime.Now;

        //WriteLine("TolocalTime : " + fecha.ToLocalTime());
        //WriteLine("TolongDateString : " + fecha.ToLongDateString());
        //WriteLine("TolongTimeString : " + fecha.ToLongTimeString());
        //WriteLine("ToODate : " + fecha.ToOADate());
        //WriteLine("ToChortDateTime : " + fecha.ToShortDateString());
        //WriteLine("ToChorTimeString : " + fecha.ToShortTimeString());
        //WriteLine("ToString : " + fecha.ToString());
        //WriteLine("ToUniversalTime : " + fecha.ToUniversalTime());
        //ReadLine();

        string fechaString = String.Format("La fecha de hoy es : {0:dd/MM/yyyy hh:mm:ss}", DateTime.Now);

        WriteLine(fechaString);
        ReadLine();
    }
}