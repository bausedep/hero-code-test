using Hero.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakeVoucherApi : IVoucherApi
    {
        public async Task<VoucherDTO> GetVoucherAsync(int bookingId, string paxId)
        {
            await Task.CompletedTask;
            return new VoucherDTO
            {
                VoucherURl = "https://www.travelr.me/"
            };
        }
    }
}
