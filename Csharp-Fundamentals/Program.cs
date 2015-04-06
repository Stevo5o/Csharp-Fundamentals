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
            Person person = new Person("SteJ", "O'Connor");

            Console.WriteLine(person.SayHello("SteJ"));
        }
    }
}
