using System;
using System.Collections.Generic;
using System.Text;

namespace Hero.Service.DTO
{
    public class PaxDTO
    {
        public string Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int Age { get; set; }
        public object Notes { get; set; }
        public object NationalityIso { get; set; }
        public int Gender { get; set; }
        public object ExternalReference { get; set; }
        public object Address { get; set; }
        public object Country { get; set; }
        public object Postcode { get; set; }
        public object Title { get; set; }
    }
}
