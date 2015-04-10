using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public class Person
    {
        // automatic properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public string MiddleName { get; private set; }

        // remove overload and add optional parameters
        public Person(string firstName, string lastName = "")
        {
            FirstName = firstName;  
            LastName = lastName;
        }

        public string SayHello(string name)
        {
            return "Hello there, " + name;
        }

        // overload
        public string SayHello(Person person)
        {
            return SayHello(person.FirstName
                + " " + person.LastName);
        }

    }
}