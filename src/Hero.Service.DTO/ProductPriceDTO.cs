using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  Hero.Service.DTO
{
    public class ProductPriceDTO
    {
        public int ProductId { get; set; }
        public string DateCheckIn { get; set; }
        public string DateCheckOut { get; set; }
        public decimal Rrp { get; set; }
        public decimal Commission { get; set; }
        public string CurrencyIso { get; set; }
    }
}
