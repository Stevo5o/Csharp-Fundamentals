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
                "Justi",
                "Jimmy",
                "Jonno",
                "Jenny"
            };

            Person stej = new Person("SteJ", "O'Connor");

            Console.WriteLine(stej.SayHello(names));
            Console.WriteLine(stej.SayHello("Justi", "Jimmy", "Jonno", "Jenny", "Joshy", "SteJ"));
        }
    }
}







