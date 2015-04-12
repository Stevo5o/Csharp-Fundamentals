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

            // use var instead of generics
            var namesList = new List<string>();
            namesList.AddRange(names);

            // lambda expression
            var newList = namesList.FindAll((s) => s[1] == 'i');

            foreach (var name in newList)
            {
                Console.WriteLine(name);  
            }            
        }
    }
}





