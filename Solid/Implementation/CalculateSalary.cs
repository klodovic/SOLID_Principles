using Solid.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Implementation
{
    internal class CalculateSalary : ICalculateSalary
    {
        public double CalculateEmployeeSalary(double totalTicketIncome, int precentage)
        {
            double totalSalary = (totalTicketIncome * precentage) / 100;
            return totalSalary;
        }
    }
}
