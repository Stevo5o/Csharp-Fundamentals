using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder x = new StringBuilder(),
            y = x;

            x.Append("Hello ");
            y.Append("World!");

            Console.WriteLine(x.ToString());

            x = null;

            Console.WriteLine(x); // blank line
            Console.WriteLine(y.ToString());            
        }
    }
}
