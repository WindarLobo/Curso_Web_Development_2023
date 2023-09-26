using static System.Console;
namespace CursoCSharp_3_encapsulacion;

internal class Program
{
    static void Main(string[] args)
    {

        Point point = new Point();
        point.x = 5000;

        try
        {
            PointEncapsulado pointEnc = new PointEncapsulado();
            //pointEnc.SetX(80);
            //pointEnc.Sety(90);
            
            //pointEnc.X = 56;

            pointEnc.SetXPrivate(56);
            pointEnc.SetYPrivate(90);

            WriteLine(pointEnc.GetX());
            WriteLine(pointEnc.GetY());

            WriteLine(pointEnc.X);
        }
        catch (Exception ex)
        {
            WriteLine("Excepcion");
        }
    }
}