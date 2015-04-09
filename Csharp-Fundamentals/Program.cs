﻿using Csharp_Fundamentals.MyFirstDataTypes;
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
            Person stej = new Person("SteJ", "O'Connor"),
                kate = new Person("Kate", "Bush");

            string greeting = stej.SayHello(kate);

            Console.WriteLine(greeting);
        }
    }
}
