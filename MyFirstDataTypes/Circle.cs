using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    class Circle : Shape 
    {
        public double Radius { get; private set;  }

        public Circle(double radius)
        {
            Radius = radius;
            _Sides = 0;
        }

        public override double Area
        {
            get { return Math.PI * Radius * Radius;  }
        }
    }
}
