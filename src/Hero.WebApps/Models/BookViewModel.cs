using Hero.Service.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Hero.WebApps.Models
{
    public class BookViewModel
    {

        public BookViewModel(ProductDTO productDTO, IEnumerable<ScheduleDTO> scheduleDTO)
        {
            ProductName = productDTO.Name;
            ShortDescription = productDTO.ShortDescription;
            LongDescription = productDTO.LongDescription;
            ImageURls = productDTO.ImageUrls.Select(i => i.Url).ToList();
            ProductId = productDTO.Id;
        }
        public BookViewModel()
        {

        }
        [Required]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public IEnumerable<string> ImageURls { get; set; }
        [Required]
        public string CheckInDate { get; set; }
        [Required]
        public string CheckInTime { get; set; }
        
        public decimal DiscountAmount { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal FinalPrice { get => OriginalPrice - DiscountAmount; }
        public string Currency { get; set; }
        public void CalculateFinalPrice(ProductPriceDTO productPricingDTO)
        {
            Currency = productPricingDTO.CurrencyIso;
            //* For this test, we’ll offer the user a discount on the price equal to 50% of the travel agency’s commission.
            DiscountAmount = (productPricingDTO.Commission * 0.5m);
            OriginalPrice = productPricingDTO.Rrp;
        }

    }
}
