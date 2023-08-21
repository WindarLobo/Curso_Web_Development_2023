namespace CursoCSharp_6_switch
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            var numero = 15;

            switch (numero)
            {

                case 0:
                   
                    break;
                case 10:
                   
                    break;
                case 15:
                  
                    break;
                default: 
                  
                    break;
            };
            if(numero == 0)
            {
                Console.WriteLine("Es un 0");

            }
            else
            {
                if(numero == 10)
                {
                    Console.WriteLine("Es un 10");
                }
                else
                {
                    if (numero == 15)
                    {
                        Console.WriteLine("Es un 15");
                    }
                    else
                    {

                        Console.WriteLine("No coincide con  nada");
 

                    }
                }
            }

        }
    }
}