namespace CursoCSharp_3_nomeclatura
{
    internal class Program
    {
        private readonly string _estaEsMiCadena;
        static void Main(string[] args)
        {
            //Camel case
            var estoEsUnaVariable = "Hola";

            //Pascal

            var EstoEsUnaVariable = "Pascal";
        }
        //Bien

        public int  SumaDosNumero(int num1,int num2)
        {
           var resultado = num1 + num2;
            return resultado;


        }
        //Mal

        public int  Sumar(int a,int b)
        {
            var c = a + b;
            return c;
        }

    }
}