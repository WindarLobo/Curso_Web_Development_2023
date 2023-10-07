namespace CursoCSharp_3_constante;

public class Program
{
   
        //Constante
        const int IVA = 7;
        const int IVA7 = 7, IVA11 = 11, IVA21 = 21;

        private int Importe { get; set; }

    public int CalcularImporte(int importe)
    {
        IVA = 11;//No se puede modificar

        return importe + (importe*IVA);
    }

}