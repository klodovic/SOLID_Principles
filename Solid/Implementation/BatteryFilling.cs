using Solid.Interface;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Implementation
{
    public class BatteryFilling : IChargingBattery
    {
        public List<ElectricVehicle> Fill(List<ElectricVehicle> vehicles)
        {
            List<ElectricVehicle> loadedVehicles = new List<ElectricVehicle>();
            foreach (ElectricVehicle v in vehicles)
            {
                if (v.BatteryLevel < 10)
                {
                    loadedVehicles.Add(new ElectricVehicle(v.Name, 100));
                }
                else
                {
                    loadedVehicles.Add(v);
                }
            }
            return loadedVehicles;
        }
    }
}
