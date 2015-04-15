using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public class Employee : Person, ISalariable, IFirable
    {
        public Employee(string firstName, string lastName, EmployeePosition position, decimal salary) 
            : base(firstName, lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("lastName cannot be null, empty, or whitespace");
            }

            if (_Salary < 1)
            {
                throw new ArgumentException("Salary cannnot be less than 1");
            }

            Position = position;
            _Salary = salary;
        }       

        public EmployeePosition  Position { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + ", " + Position;
        }

        public override string SayHello(string name)
        {
            return "Hi. How may I help you, " + name + "?";
        }

        private decimal _Salary;

        public decimal Salary
        {
            get { return _Salary; }
        }

        public void PaySalary()
        {
            // something important
        }

        public void Fire()
        {
            _Salary = 0;
            // some imaportant code
        }
    }
}
