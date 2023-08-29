using static System.Console;
namespace Ejercicio_Dos_;

internal class Program
{
    private static double total;
    private const String Suma = "+";
    private const String Resta = "-";
    private const String Multiplicacion = "*";
    private const String Division = "/";
    private const String Raiz = "%";
    static void Main(string[] args)
    {


        /*Crear una calculadora , usando funciones de suma, resta, multiplicación y división.
          Se creara un menú por consola, de la siguiente forma:

           1- Suma

           2- Resta

           3- Multiplicación

           4- División

          Seleccione la opción:
         dependiendo de la selección, se pedirán 2 números, y usando las funciones creadas, 
        devolverá el resultado por consola*/

        try
        {
            realizarOperacionBasicas();
            ReadLine();
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }

    }


    public static void realizarOperacionBasicas()
    {
        do
        {


            WriteLine("Introduce el primer numero");

            string usuarioNumeroUno = ReadLine();


            if (double.TryParse(usuarioNumeroUno, out double num1))
            {
                WriteLine("Introduce el segundo numero");

                string usuarioNumeroDos = ReadLine();


                if (double.TryParse(usuarioNumeroDos, out double num2))
                {

                    WriteLine("Que operacion quieres hacer " + "( \"+\" = Suma , \"-\" = Resta , \"*\" " + "= Multiplicacion , \"/\" = Division ,  \"%\" = Raiz ");
                    string usuario = ReadLine();

                    if (!usuario.Equals("+") && !usuario.Equals("-") && !usuario.Equals("*") && !usuario.Equals("/") && !usuario.Equals("%"))
                    {
                        WriteLine("Error al introducir");
                    }
                    else
                    {
                        double resultado = OperacionesBasicas(num1, num2, usuario);
                        WriteLine(resultado);
                        break;
                    }
                }

            }
            else
            {

                WriteLine("Error al introducir");

            }

        } while (true);

    }

    private static double OperacionesBasicas(double numero1, double numero2, String usuario)
    {

        do
        {
            switch (usuario)
            {

                case Suma:
                    total = numero1 + numero2;
                    break;

                case Resta:
                    total = numero1 - numero2;
                    break;

                case Multiplicacion:
                    total = numero1 * numero2;
                    break;

                case Division:
                    if (numero2 == 0)
                    {
                        throw new Exception("No se puede dividir entre 0");

                    }
                    total = numero1 / numero2;
                    break;

                case Raiz:
                    total = (float)Math.Pow(numero1, (1 / numero2));
                    break;

                default:
                    WriteLine("Error al introducir");
                    break;

            }

            return total;

        } while (true);

    }

}





