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

            string hello = "Hello, World!";
            //string heo = "Heo, Word!";

            //int index = hello.IndexOf("l");
            //int index1 = heo.IndexOf("l");

            // System.ArgumentOutOfRangeException
            //do
            //{
            //    heo = heo.Remove(index1, 1);
            //    index1 = heo.IndexOf("l");
            //}

            // while (index > -1);
            //{
            //    hello = hello.Remove(index, 1);
            //    Console.WriteLine( hello, "I'm in the loop");
            //    index = hello.IndexOf("l");
            //}

            // Console.WriteLine(heo);
            // Console.WriteLine(hello);

            foreach (char c in hello)
            {
                Console.Write(c);
            }

            Console.WriteLine(string.Empty);
        }
    }
}







