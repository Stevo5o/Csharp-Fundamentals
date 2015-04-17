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

            //var nameWithE = names.FindAll(FindNamesWithE);
            var nameWithE = names.FindAll(
                delegate(string name)
                {
                    return name.IndexOf("e") == 1;
                }
            );

            foreach (var name in nameWithE)
            {
                Console.WriteLine(name);
            }
        }

        //static bool FindNamesWithE(string name)
        //{
        //    return name.IndexOf("e") == 1;
        //}
    }
}





