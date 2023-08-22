namespace CurCSarp_4_Contantes
{
    internal class Program

    {
        public const string NOMBRE = "Windar";
        public const int NUMERO_PEDIDO_MAXIMO = 10;
        static void Main(string[] args)
        {
            //Esto no se puede hacer
            //NUMERO_PEDIDO_MAXIMO = 12;
            for (int i =0;i<12;i++)
            {
                if (i < NUMERO_PEDIDO_MAXIMO)
                {
                    Console.WriteLine(i);
                }
            }
         
        }
    }
}