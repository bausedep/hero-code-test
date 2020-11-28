using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class LocationDTO
    {
        public int Type { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

}
