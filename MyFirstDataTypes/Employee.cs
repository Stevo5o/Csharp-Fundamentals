using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName, string position) 
            : base(firstName, lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("lastName cannot be null, empty, or whitespace");
            }

            if (string.IsNullOrEmpty(position) || string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Position cannot be null, empty, or whitespace");
            }

            Position = position;          
        }       

        public string Position { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + ", " + Position;
        }

        public override string SayHello(string name)
        {
            return "Hi. How may I help you, " + name + "?";
        }
    }
}
