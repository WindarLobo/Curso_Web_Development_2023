
using static System.Console;
namespace CursoCSharp_5_poliformismo;

internal class Program
{
    static void Main(string[] args)
    {
        Gato gato = new Gato();
        gato.HacerRuido();

        Perro perro = new Perro();
        perro.HacerRuido();

        Lobo lobo = new Lobo();
        lobo.HacerRuido();

        ReadLine();

        List<Animal> animales= new List<Animal>();

        animales.Add(gato);
        animales.Add(perro);
        animales.Add(lobo);
      
        foreach (var animal in animales)
        {
            animal.HacerRuido();
        }
        ReadLine();
    }
}