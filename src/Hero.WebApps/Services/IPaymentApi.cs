using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IPaymentApi
    {
        [Post("/payments")]
        Task CreatePaymentAsync(CreatePaymentCommand createPaymentCommand);
    }
}
