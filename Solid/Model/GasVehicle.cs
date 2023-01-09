using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class GasVehicle : Vehicle
    {
        public double GasLevel { get; set; }

        public GasVehicle(){}

        public GasVehicle(string name, double gasLevel) : base(name)
        {
            Name= name;
            GasLevel = gasLevel;
        }

        public bool IsValid(GasVehicle gasVehicle)
        {
            try
            {
                if (gasVehicle.GasLevel < 0 || gasVehicle.GasLevel > 99)
                {
                    Console.WriteLine("Gas level must be between 0 and 100.00");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }

        public override string ToString() => $"{Name} has tank filled up to {GasLevel}%";
    }
}
