using Solid.Interface;
using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Implementation
{
    public class FuelFilling : IChargingGas
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
    }
}
