using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interface
{
    public interface IChargingBattery
    {
        List<ElectricVehicle> Fill(List<ElectricVehicle> electricVehicles);
    }
}
