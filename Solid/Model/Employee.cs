using Solid.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Employee : Person
    {
        public Salary Salary { get; set; }
        public Employee(string firstName, string lastName, Salary salary) : base(firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString() => $"Employee: {FirstName} {LastName}";

    }
}
