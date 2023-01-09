using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interface
{
    public interface ICalculate<T>  where T : class
    {
        double CalculateHeavyIncome(List<LargeTrain> trains);
        double CalculateLightIncome(List<SmallTrain> trains);
        double CalculateSalary(double totalTicketIncome, int precentage);
    }
}
