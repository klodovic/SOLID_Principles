using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interface
{
    public interface ICharging<T> where T : class
    {
        List<GasVehicle> Fill(List<GasVehicle> vehicles);
        List<ElectricVehicle> Fill(List<ElectricVehicle> electricVehicles);
    }
}
