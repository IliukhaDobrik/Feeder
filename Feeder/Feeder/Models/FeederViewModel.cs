using BussinesLayer.Enums;
using System;

namespace Feeder.Models
{
    public sealed class FeederViewModel
    {
        public Guid UserId { get; set; }
        public string Model { get; set; }
        public double Capacity { get; set; }
        public double Size { get; set; }
        public FeederType Type { get; set; }
    }
}
