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

            //char[] foo = new char[5];

            //foo[0] = 'H';
            //foo[1] = 'e';
            //foo[2] = 'l';
            //foo[3] = 'l';
            //foo[4] = 'o';

            char[] foo = new char[] {
                'H', // 0
                'e', // 1
                'l', // 2
                'l', // 3
                'o' // 4
            };

            for (int i = 0; i < foo.Length; i++)
            {
                Console.Write(foo[i]);
            }

            Console.WriteLine(string.Empty);

            foreach (var item in foo)
            {
                Console.Write(item);
            }

            Console.WriteLine(string.Empty);
        }
    }
}







