using Hero.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakePaymentApi : IPaymentApi
    {
        public Task CreatePaymentAsync(CreatePaymentCommand createPaymentCommand)
        {
            return Task.CompletedTask;
        }
    }
}
