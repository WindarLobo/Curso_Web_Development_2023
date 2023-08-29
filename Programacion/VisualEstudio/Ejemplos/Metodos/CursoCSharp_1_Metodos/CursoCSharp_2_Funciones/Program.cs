using static System.Console;
namespace CursoCSharp_2_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
           String saludo= Saludo("Windar","Lobo");
            WriteLine(saludo);
        }
      
      //Se le pasa parametros y devulve un  valor

        public static String Saludo(String nombre,String apellidos)
        {
            return "Mi nombre es :" + nombre + " " + apellidos;
        }

        //Que solo ejecuta codigo

        public static  void Metodo()
        {
            WriteLine("Valor");
        }

        //Devuelve valor pero no recibe nada

        public static  int FuncionSinParametros()
        {
            return 7 + 8;
        }

        //Metodo, que no devuelve valor y recibe parametros

        public static void FuncionCosParametros(int año,int edad) 
        {
            WriteLine(año + " " + edad);    
        }


    }
}