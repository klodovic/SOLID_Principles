using Solid.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Model
{
    public class Train
    {
        public TrainType TrainType { get; set; }

        public Train(TrainType trainType)
        {
            TrainType = trainType;
        }
    }
}
