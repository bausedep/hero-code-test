using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakeProductPricingApi : IProductPricingApi
    {


        public async Task<ProductPriceDTO> GetProductPriceAsync(int id, string dateCheckIn, int night = 1)
        {
            await Task.CompletedTask;
            return new ProductPriceDTO()
            {
                CurrencyIso = "AUD",
                Commission=100,
                DateCheckIn = dateCheckIn,
                Rrp= 200
            };
        }
    }
}
