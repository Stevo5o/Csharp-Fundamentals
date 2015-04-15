using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public static class ShapeUtility
    {
        public static bool IsPolygon(this Shape shape)
        {
            return shape.Sides >= 3;
        }
    }
}
