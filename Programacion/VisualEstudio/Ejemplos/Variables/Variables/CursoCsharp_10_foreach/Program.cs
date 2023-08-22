using static System.Console;
namespace CursoCsharp_10_foreach
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var listaDeNumero = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int numero in listaDeNumero)
            //{
            //    Console.WriteLine(numero);
            //}

            var listaDePersonas = new List<Persona>();
            var persona1 = new Persona()
            {
                name = "Windar Sujey",
                lastname = "Lobo Garces",
                edad = 30,
            };
            var persona2 = new Persona()
            {
                name = "Adrian",
                lastname = "Estevez Gayoso",
                edad = 32,

            };
            listaDePersonas.Add(persona1);
            listaDePersonas.Add (persona2);


            foreach (var persona in listaDePersonas)
            {
                WriteLine(persona.name+ " "+ persona.lastname + " tiene " + persona.edad + " años");

            }

        }
        public class Persona
        {

            public string name { get; set; }
            public string lastname { get; set; }
            public int edad { get; set; }
        }

    }


}
