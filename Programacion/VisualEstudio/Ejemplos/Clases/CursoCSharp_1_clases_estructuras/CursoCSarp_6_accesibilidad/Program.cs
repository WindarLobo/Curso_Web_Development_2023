using CursoCSharp_6_accesibilidad;

namespace CursoCSarp_6_accesibilidad
{
    public class Program
    {
        static void Main(string[] args)
        {
           ClasesDerivadas clasedv= new ClasesDerivadas();
            clasedv.Nacionalidad = "Española";
            clasedv.Nombre = "Alejandro";
            clasedv.Telefono = "1234566987";
            clasedv.Sumar(6, 7);
         

        }
    }
}