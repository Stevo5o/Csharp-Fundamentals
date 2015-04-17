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
            var names = new List<string> {
                "Justy",
                "Jimmy",
                "Jonny",
                "Jenny",
                "Jakey",
                "Julie",
                "Jeffy",
                "Jammy",
                "Jacky"
            };

            // creating delegate
            Func<string, bool> fn = n => n.IndexOf("e") == 1;
            // Predicate<string> pred = n => n.IndexOf("e") == 1;

            Func<int, string, bool> fn2 = (i, s) =>
            {
                return true;
            };

            bool result = fn("ae");

            //var nameWithE = names.FindAll(FindNamesWithE);
            var nameWithE = names.FindAll(n => n.IndexOf("e") == 1);

            foreach (var name in nameWithE)
            {
                Console.WriteLine(name);
            }
        }

        static bool FindNamesWithE(string name)
        {
            return name.IndexOf("e") == 1;
        }
    }
}





