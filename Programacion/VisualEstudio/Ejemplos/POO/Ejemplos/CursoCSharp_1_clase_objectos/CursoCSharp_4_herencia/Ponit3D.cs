﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_4_herencia
{
    public class Point3D : Point , IEjemplo 
    {
        public int Z { get; private set; }
        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetZ(int value)
        {
            if (value < 100)
                Z = value;
            else
                throw new ArgumentOutOfRangeException();

        }

        public int GetZ() { return Z; }
    }
}
