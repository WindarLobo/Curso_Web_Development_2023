using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_4_herencia
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }


        public void SetX(int value)
        {
            if (value < 100)
               X = value;
            else
                throw new ArgumentOutOfRangeException();

        }
        public void Sety(int value)
        {
            if (value > 50)
               Y = value;
            else
                throw new ArgumentOutOfRangeException();

        }
        public int GetX() { return X; }
        public int GetY() { return Y; }

    }
}
