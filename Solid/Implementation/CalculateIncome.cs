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
    public class CalculateIncome : ICalculateIncome
    {
        public double CalculateTotalIncome(List<SmallTrain> small, List<LargeTrain> large)
        {
            double income = 0;
            foreach (var t in small)
            {
                income = income + (double)t.Price;
            }
            foreach (var t in large)
            {
                income = income + (double)t.Price;
            }
            return income;
        }
    }
}
