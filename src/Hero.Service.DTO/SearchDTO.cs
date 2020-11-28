using System;
using System.Collections.Generic;
using System.Text;

namespace Hero.Service.DTO
{
    public class SearchDTO
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string SupplierName { get; set; }
        public string SupplierProductCode { get; set; }
        public string BranchName { get; set; }
        public int Category { get; set; }
        public int DurationInMinutes { get; set; }
        public int NumberOfNights { get; set; }
        public string FormattedAddressName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
    }
}
