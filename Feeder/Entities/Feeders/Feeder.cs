using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Feeders
{
    public abstract class Feeder
    {
        public string Model { get; set; }
        public double Capacity { get; set; }
        public double Size { get; set; }
    }
}
