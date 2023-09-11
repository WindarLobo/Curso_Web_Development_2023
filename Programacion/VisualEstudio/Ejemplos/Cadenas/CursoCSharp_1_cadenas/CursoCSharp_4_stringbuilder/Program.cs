using System.Text;
using static System.Console;
namespace CursoCSharp_4_stringbuilder;

internal class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder("Hola soy Windar");

        sb.Append("Hola soy Windar");
        sb.Append(" y vivo en Tomiño");
        //WriteLine(sb);
        //ReadLine();

        sb2.AppendLine(" y vivo en Tomiño");
        sb2.AppendFormat("actualmente {0: dd-MM-yyyy}", DateTime.Now);

        //WriteLine(sb2);
        //ReadLine();

        if (sb.Capacity > 1)
        {
            WriteLine(sb);
            ReadLine();
        }
        if (sb2.Length > 1)
        {
            WriteLine(sb2);
            ReadLine();

        }
    }
}