using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class FakeBookingApi : IBookingApi
    {
        public async Task<BookingProductDTO> CreateBookingAsync([Body] CreateBookingCommand command)
        {
            await Task.CompletedTask;
            return new BookingProductDTO
            {
                Id = 1
            };
        }

        public async Task<BookingProductDTO> FinalizeBookingAsync(int bookingId)
        {
            await Task.CompletedTask;
            return new BookingProductDTO()
            {
                Id = 1
            };
        }

        public async Task<BookingValidationResultDTO> ValidateBookingAsync(int bookingId)
        {
            await Task.CompletedTask;
            return new BookingValidationResultDTO()
            {
              IsValid= true
            };
        }
    }
}
