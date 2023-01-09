using Solid.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class LargeTrain : Train
    {
        public HeavyVehiclePrice Price { get; set; }
        public LargeTrain(TrainType trainType, HeavyVehiclePrice price) : base(trainType)
        {
            Price = price;
        }

        public override string ToString() => $"Train size {TrainType} = {((int)TrainType)}, Price for {Price} = {((int)Price)}kn";
    }
}
