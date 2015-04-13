using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName) 
            : base(firstName, lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("lastName cannot be null, empty, or whitespace");
            }
        }
    }
}
