using Hero.Service.DTO;
using Refit;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IBookingApi
    {
        [Post("/bookings")]
        Task<BookingProductDTO> CreateBookingAsync([Body] CreateBookingCommand command);

        [Post("/bookingvalidate/{bookingId}")]
        Task<BookingValidationResultDTO> ValidateBookingAsync(int bookingId);

        [Get("/bookingfinalise/{bookingId}")]
        Task<BookingProductDTO> FinalizeBookingAsync(int bookingId);
    }
}
