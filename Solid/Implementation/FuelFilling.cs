using Solid.Interface;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Implementation
{
    public class FuelFilling<T> : ICharging<T> where T : class
    {
        public List<GasVehicle> Fill(List<GasVehicle> vehicles)
        {
            List<GasVehicle> loadedVehicles = new List<GasVehicle>();
            foreach (GasVehicle v in vehicles)
            {
                if (v.GasLevel < 10)
                {
                   loadedVehicles.Add(new GasVehicle(v.Name, 100));
                }
                else
                {
                    loadedVehicles.Add(v);
                }
            }
            return loadedVehicles;
        }

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
