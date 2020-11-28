using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IProductPricingApi
    {
        [Get("/productpricing/{id}/{dateCheckIn}/{nights}")]
        Task<ProductPriceDTO> GetProductPriceAsync(int id,string dateCheckIn,int nights = 1);
    }
}
