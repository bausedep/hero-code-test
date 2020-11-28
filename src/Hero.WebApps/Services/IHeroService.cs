using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IHeroService
    {
        IProductApi ProductApi { get; }
        IProductPricingApi ProductPricingApi { get; }
        IPaxApi PaxApi { get; }
        ISearchApi SearchApi { get; }
        IScheduleApi ScheduleApi { get; }
        IPaymentApi PaymentApi { get; }
        IBookingApi BookingApi { get; }

        IVoucherApi VoucherApi { get; }
    }
}
