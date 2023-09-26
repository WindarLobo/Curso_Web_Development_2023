namespace CursoCSharp_1_clase_objectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CuentaBancaria cuenta1= new CuentaBancaria();

            cuenta1.Saldo = 1500;

            CuentaBancaria cuenta2= new CuentaBancaria();

            cuenta2.Saldo = 2500;

            int suma= cuenta1.Saldo+cuenta2.Saldo;

            
        }
    }
}