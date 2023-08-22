namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje =Console.ReadLine();
            String hola = null;
            int edad = default(int);// 0 
            int? altura=null; // esto significa que una variable es null

            bool verdadero = default (bool); // el valor de un tipo bool es false 
            edad = edad + 15;
         

            if (altura == null)
            {
                //Hacer algo

            }
            DateTime? fecha = new DateTime();
            fecha = null;
            int? dia = fecha?.Day;// dame el valor nulo de la feccha
            Console.WriteLine(edad);
            Console.ReadLine();
            var vaiable = edad + "Hola";
        }
    }
}