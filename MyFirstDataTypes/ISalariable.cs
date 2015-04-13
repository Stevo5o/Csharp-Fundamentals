using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public interface ISalariable
    {
        decimal Salary { get; }
        void PaySalary();
    }
}
