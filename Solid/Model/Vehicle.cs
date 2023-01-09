using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Solid.Model
{
    public class Vehicle
    {

        public string Name { get; set; }
        public Vehicle(){}
        public Vehicle(string name)
        {
            Name = name;
        }
    }
}
