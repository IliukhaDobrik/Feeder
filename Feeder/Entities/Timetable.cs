﻿using Entities.Feeders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Timetable
    {
        public Guid TimeTableId { get; set; }
        public string TimeTableName { get; set; }
        public DateTime Date { get; set; }
        public Feeder TypeFeeder { get; set; }
    }
}
