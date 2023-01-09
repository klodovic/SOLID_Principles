using Solid.Enum;
using Solid.Interface;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Class
{
    public class CalculateIncome<T> : ICalculate<T> where T : class
    {
        public double CalculateHeavyIncome(List<LargeTrain> trains)
        {
            double income = 0;
            foreach (var t in trains)
            {
                income = income + (double)t.Price;
            }
            return income;
        }

        public double CalculateLightIncome(List<SmallTrain> trains)
        {
            double income = 0;
            foreach (var t in trains)
            {
                income = income + (double)t.Price;
            }
            return income;
        }

        public double CalculateSalary(double totalTicketIncome, int precentage)
        {
            double totalSalary = (totalTicketIncome * precentage) / 100;
            return totalSalary;
        }
    }
}
