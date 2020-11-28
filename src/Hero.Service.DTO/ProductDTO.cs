using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.Service.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public bool LiveAvailability { get; set; }
        public int ConfirmationType { get; set; }
        public string Name { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLogoUrl { get; set; }
        public int DurationMinutes { get; set; }
        public string DurationText { get; set; }
        public string SupplierBranchName { get; set; }
        public int SupplierBranchId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<ProductImageDTO> ImageUrls { get; set; }
        public List<string> Tags { get; set; }
        public List<LocationDTO> Locations { get; set; }
        public List<string> MapUrls { get; set; }
        public string SupplierId { get; set; }
        public List<int> SubProducts { get; set; }
        public int AdvertisedPrice { get; set; }
        public string CurrencyIso { get; set; }
        public int PricedPerXPax { get; set; }
        public string SupplierProductCode { get; set; }
        public int Availability { get; set; }
        public int MinStay { get; set; }
        public int MaxStay { get; set; }
        public bool SaleFare { get; set; }
        public bool VariablePrice { get; set; }
        public bool Cta { get; set; }
        public bool Ctd { get; set; }

        public ProductDTO()
        {
            ImageUrls = new List<ProductImageDTO>();
            Tags = new List<string>();
            Locations = new List<LocationDTO>();
            MapUrls = new List<string>();
            SubProducts = new List<int>();
        }
    }

}
