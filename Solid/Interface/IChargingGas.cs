﻿using Solid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Interface
{
    public interface IChargingGas
    {
        List<GasVehicle> Fill(List<GasVehicle> vehicles);
    }
}
