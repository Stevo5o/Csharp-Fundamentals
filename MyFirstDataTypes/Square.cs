using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    class Square : Shape
    {
        public double Length { get; private set; }
        public Square(double sideLength)
        {
            Length = sideLength;
            _Sides = 4;

        }
        public override double Area
        {
            get { return Length * Length; }
        }
    }
}
