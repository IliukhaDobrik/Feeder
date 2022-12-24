using BussinesLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Dtos
{
    public sealed class FeederRequestDto
    {
        public string Model { get; set; }
        public double Capacity { get; set; }
        public double Size { get; set; }
        public FeederType Type { get; set; }
    }
}
