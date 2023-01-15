using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interface
{
    public interface ICalculateSalary
    {
        double CalculateEmployeeSalary(double totalTicketIncome, int precentage);
    }
}
