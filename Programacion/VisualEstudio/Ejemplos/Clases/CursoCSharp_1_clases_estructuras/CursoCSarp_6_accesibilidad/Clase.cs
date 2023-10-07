using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_6_accesibilidad
{
    public  class Clase
    {
        public string Telefono { get; set; }//puede octener acceso desde la misma clase, clase deriva de esta clase 
        private  int  Edad { get; set; }// es acceso de esta misma clase o estructura
        internal string Nombre  { get; set; }// puede tener acceso al tipo o miembro y metodos, mismo ensamblado 
        protected string Apellidos { get; set; }//accesede de la misma clase o codigo derivada de esta 
        protected internal string Nacionalidad { get; set; }// puede acceder solamente del mismo ensamblado pero a la clase derivada 

        public Clase()
        {
            Edad = 16;
            Apellidos = "Lobo";
        }
        public void Sumar(int a,int b)
        {

        }
    }
}
