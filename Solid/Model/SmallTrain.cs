using Solid.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class SmallTrain : Train
    {
        public LightVehiclePrice Price { get; set; }
        public SmallTrain(TrainType trainType,  LightVehiclePrice price) : base(trainType)
        {
            Price = price;
        }

        public override string ToString() => $"Train size {TrainType} = {((int)TrainType)}, Price for {Price} = {((int)Price)}kn";
    }
}
