using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_3_encapsulacion
{
    public class PointEncapsulado
    {
        public  int X { get; private set; }
        public int Y { get; private set; }


        //public void SetX(int value)
        //{
        //    if (value < 100)
        //        x = value;
        //    else
        //        throw new ArgumentOutOfRangeException();

        //}
        //public void Sety(int value)
        //{
        //    if (value > 50)
        //       y= value;
        //    else
        //        throw new ArgumentOutOfRangeException();

        //}
        public void SetXPrivate(int value)
        {
            if (value < 100)
                X = value;
            else
                throw new ArgumentOutOfRangeException();

        }
        public void SetYPrivate(int value)
        {
            if (value> 50)
               Y = value;
            else
                throw new ArgumentOutOfRangeException();

        }

        public int GetX() { return X; }
        public int GetY() { return Y; }

    }
}
