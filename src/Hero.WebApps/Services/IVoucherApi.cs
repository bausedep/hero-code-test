using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IVoucherApi
    {

        [Get("/vouchers/{bookingId}/{paxId}")]
        public Task<VoucherDTO> GetVoucherAsync(int bookingId, string paxId);
    }
}
