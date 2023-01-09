using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class ElectricVehicle : Vehicle
    {
        public double BatteryLevel { get; set; }
        public ElectricVehicle(){}
        public ElectricVehicle(string name, double batteryLevel) : base(name) 
        {
            Name = name;
            BatteryLevel = batteryLevel;
        }

        public bool IsValid(ElectricVehicle eletricVehicle)
        {
            try
            {
                if (eletricVehicle.BatteryLevel < 0 || eletricVehicle.BatteryLevel > 99)
                {
                    Console.WriteLine("Battery level must be between 0 and 100.00");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return true;
        }

        public override string ToString() => $"{Name} has battery filled up to {BatteryLevel}%";

    }
}
