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
            string name = "SteJ O'Connor";

            int index = name.IndexOf("n",
                name.IndexOf("n") + 1);

            string lastIndex = name.Substring(5, 2);
            string removeIndex = name.Remove(0, 7);
            string replaceIndex = name.Replace("O'Connor", string.Empty);
            string replaceNwithL = name.Replace("n", "l");

            Console.WriteLine(index);
            // 10

            Console.WriteLine(lastIndex);
            // O'Connor (5)
            
            Console.WriteLine(lastIndex);            
            // O'

            Console.WriteLine(removeIndex);
            // Connor

            Console.WriteLine(replaceIndex);
            // SteJ

            Console.WriteLine(replaceNwithL);
            // SteJ O'Collor
        }
    }
}
