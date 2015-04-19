using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape nullShape = null;

                Console.WriteLine(nullShape.IsPolygon());
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot Error");
            }        
        }
    }
}





