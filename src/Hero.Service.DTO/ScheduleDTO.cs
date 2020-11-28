using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class ScheduleDTO
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int Availability { get; set; }
        public bool Available { get; set; }
        public bool Cta { get; set; }
        public bool Ctd { get; set; }
        public int MinStay { get; set; }
        public int MaxStay { get; set; }
        public bool Stopsell { get; set; }
    }
}
