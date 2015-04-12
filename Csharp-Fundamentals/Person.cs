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
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be null, empty or whitespace");
            }

            if ((lastName == null || lastName.Trim() == string.Empty) && lastName != string.Empty)
            {
                throw new ArgumentException("Last name cannot be null or whitespace");
            }

            FirstName = firstName;
            LastName = lastName;
        }

        public string SayHello(string name)
        {
            // null
            // empty
            // whitespace
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null, empty or whitespace");
            }

            return "Hello there, " + name;
        }

        // overload
        public string SayHello(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("Person cannot be null");
            }

            return SayHello(person.FirstName + " " + person.LastName);
        }

        public string SayHello(params string[] names)
        {
            //StringBuilder builder = new StringBuilder();
            //string temp = string.Empty;

            //foreach (string name in names)
            //{                
            //    builder.Append(name + ", ");
            //}

            //temp = builder.ToString();
            //temp = temp.Remove(temp.LastIndexOf(","));

            //return SayHello(temp);

            return SayHello(string.Join(", ", names));
        }
    }
}
