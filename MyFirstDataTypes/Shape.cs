using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public abstract class Shape
    {
        public abstract double Area
        {
            get;
        }

        public virtual int Sides
        {
            get { return _Sides;  }
        }

        protected int _Sides;

        public virtual Color Color
        {
            get { return _Color;  }
        }

        protected Color _Color;
    }
}
