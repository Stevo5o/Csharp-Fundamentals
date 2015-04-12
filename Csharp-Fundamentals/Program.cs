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

            // for (initialization; condition; incrementation)
            for (int counter = 0; counter < 10; counter++)
            {
                counter = counter + 1; // 1
                int i = counter++; // i = 0; counter = 1
                int ii = ++counter; // ii = 1; counter = 1
            }

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter + 1);
            }

            string hello = "Hello, World!";

            for (int counter = 0; counter < hello.Length; counter++)
            {
                Console.WriteLine(counter + 1);
            }
        }
    }
}







