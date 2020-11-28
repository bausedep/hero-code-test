using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class HeroService : IHeroService
    {
        private readonly HttpClient _httpClient;

        public IProductApi ProductApi { get; }

        public IPaxApi PaxApi { get; }

        public ISearchApi SearchApi { get; }

        public IScheduleApi ScheduleApi { get; }
        public IProductPricingApi ProductPricingApi { get; }
        public IPaymentApi PaymentApi { get; }
        public IBookingApi BookingApi { get; }
        public IVoucherApi VoucherApi { get; }

        public HeroService(HttpClient httpClient, IProductApi productService, IPaxApi paxService,
            ISearchApi searchApi, IScheduleApi scheduleApi, IProductPricingApi productPricingApi,
            IPaymentApi paymentApi, IBookingApi bookingApi, IVoucherApi voucherApi)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            ProductApi = productService ?? throw new ArgumentNullException(nameof(productService));
            PaxApi = paxService ?? throw new ArgumentNullException(nameof(paxService));
            SearchApi = searchApi ?? throw new ArgumentNullException(nameof(searchApi));
            ScheduleApi = scheduleApi ?? throw new ArgumentNullException(nameof(scheduleApi));
            ProductPricingApi = productPricingApi ?? throw new ArgumentNullException(nameof(productPricingApi));
            PaymentApi = paymentApi ?? throw new ArgumentNullException(nameof(paymentApi));
            BookingApi = bookingApi ?? throw new ArgumentNullException(nameof(bookingApi));
            VoucherApi = voucherApi ?? throw new ArgumentNullException(nameof(voucherApi));
        }

    }
}

