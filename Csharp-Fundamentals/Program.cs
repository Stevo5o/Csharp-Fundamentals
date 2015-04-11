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
            Person stej = new Person("Stej", "O'Connor"),
                    kate = new Person("Kate", "Bush");

            // logical AND &&
            // true && true - true
            // true && false - false
            // false && true - false (short circuit)
            // false && false - false

            // logical OR ||
            // true || false - true
            // true || true - true (short circuit)
            // false || true - true 
            // false || false - false 

            // logical NOT !
            // !true - false
            // !false - true

            bool hasValue = !string.IsNullOrEmpty("test");

            bool resultName = (stej.FirstName == kate.FirstName) &&
                (stej.LastName == kate.LastName);

            bool resultString = string.IsNullOrEmpty(string.Empty);

            Console.WriteLine(resultName); // false

            Console.WriteLine(resultString); // true

            Console.WriteLine(hasValue); // true

            string str = "test";

            if (str != "test")
            {
                Console.WriteLine("This is true");
            }
            else if (str == "tEst")
            {
                Console.WriteLine("This is the second true");
            }
            else
            {
                // verbatim string literal
                Console.WriteLine(@"This is ""false""");
            }

            switch (str)
            {
                case "test":
                    Console.WriteLine(@"The value is ""test""");
                    break;
                case "Test":
                    Console.WriteLine(@"The value is ""test""");
                    break;
                case "tEst":
                    Console.WriteLine(@"The value is ""test""");
                    break;
                case "tesT":
                    Console.WriteLine(@"The value is ""test""");
                    break;
                default:
                    Console.WriteLine("No value was found");
                    break;
            }
        }
    }
}






