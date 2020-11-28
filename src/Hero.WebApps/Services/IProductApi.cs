using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IProductApi
    {
        [Get("/products/{id}")]
        Task<ProductDTO> GetProductAsync(string id,  [Query]bool verbose = true);
    }
}
