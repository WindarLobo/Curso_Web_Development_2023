using System.Security.Cryptography.X509Certificates;

namespace CursoCSharp_4_propiedades;

public class Clase
{
    public int Campo;
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; }
    public int Estado = 1;
    public readonly string Identificador;
    public Clase()
    {
        Identificador = "ABCD";
        Edad = 10;


    }
    public void Metodo(int edad)
    {
        if (edad > 18)
        {

            Edad = edad;
        }
        /*dentificador = "XXX";*/
    }
}