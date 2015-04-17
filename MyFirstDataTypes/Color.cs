using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public struct Color
    {
        // instance properties 
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }

        // constructor to set properties
        public Color(byte red, byte green, byte blue) : this()
        {
            this.R = red;
            this.G = green;
            this.B = blue;
        }

        // static properties
        public static Color Red
        {
            get { return new Color(255, 0, 0);  }
        }

        public static Color Green
        {
            get { return new Color(0, 255, 0); }
        }

        public static Color Blue
        {
            get { return new Color(0, 0, 255); }
        }

        public static Color Black
        {
            get { return new Color(0, 0, 0); }
        }

        public static Color White
        {
            get { return new Color(255, 255, 255); }
        }
    }
}
