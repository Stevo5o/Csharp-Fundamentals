using Csharp_Fundamentals.MyFirstDataTypes;
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
            #region Old Class-related code
            //Person stej = new Person("SteJ", "O'Connor"),
            //    kate = new Person("Kate", "Bush");

            //string greeting = stej.SayHello(kate);

            //Console.WriteLine(greeting); 
            #endregion

            string[] names = new string[] {
                "Justy",
                "Jimmy",
                "Jonny",
                "Jenny"
            };

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "SteJ");
            dictionary.Add("b", "Kate");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + " = " + kvp.Value);
            }

            string value = dictionary["a"]; // SteJ
        }
    }
}





