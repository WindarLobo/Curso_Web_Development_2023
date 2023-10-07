using static System.Console;
namespace CursoCSharp_1_clases_estructuras;

internal class Program
{
    static void Main(string[] args)

    {
        Point punto = new Point();
        punto.X = 10;
        punto.Y = 8;

        PointStruct puntoStruct = new PointStruct();
        puntoStruct.X = 20;
        puntoStruct.Y = 7;


        SumaCoordenadas(punto);
        SumarCoordenadas(puntoStruct);

        WriteLine($"Suma de coordenadas clase : X {punto.X} Y={punto.Y}");
        WriteLine($"Suma de coordenadas struct : X {puntoStruct.X} Y={puntoStruct.Y}");
        ReadLine();



    }
    private static void SumaCoordenadas(Point point)
    {
        point.X = point.X + 10;
        point.Y = point.Y + 10;
    }

    private static void SumarCoordenadas(PointStruct pointStruct)
    {
        pointStruct.X = pointStruct.X + 10;
        pointStruct.Y = pointStruct.Y + 10;
    }

}