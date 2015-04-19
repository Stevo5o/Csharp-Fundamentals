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
            WriteTimesTable(2);

            Console.WriteLine("We're out of WriteTimesTable");
        }

        static void WriteTimesTable(int multiplier)
        {
            for (int i = 1; i < 13; i++)
            {
                string str = string.Format("{0} * {1} = {2}",
                    i, multiplier, i * multiplier);

                Console.WriteLine(str);
            }
        }
    }
}





