using Entities.Feeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Timetable
    {
        public Guid TimetableId { get; set; }
        public string TimetableName { get; set; }
        public DateTime Date { get; set; }
        public Feeder FeederType { get; set; }
    }
}
