using Hero.WebApps.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Extensions
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddFakeService(this IServiceCollection services)
        {
            services.AddSingleton<ISearchApi, FakeSearchApi>();
            services.AddSingleton<IScheduleApi, FakeScheduleApi>();
            services.AddSingleton<IProductPricingApi, FakeProductPricingApi>();
            services.AddSingleton<IBookingApi, FakeBookingApi>();
            services.AddSingleton<IVoucherApi, FakeVoucherApi>();
            services.AddSingleton<IPaymentApi, FakePaymentApi>();
            return services;
        }

        public static IServiceCollection AddHeroApiService(this IServiceCollection services, IConfiguration configuration)
        {
            // the AddHttpClient() will provide us with an instance of HttpClient
            // available for Dependancy Injection in our services
            services.AddHttpClient<IHeroService, HeroService>(o =>
            {
                string heroApiAddress = configuration["HeroApiAddress"] ?? throw new ArgumentNullException("Hero api address is not set");
                string apiKey = configuration["ApiKey"] ?? throw new ArgumentNullException("Hero api key is not set");
                o.BaseAddress = new Uri(heroApiAddress);
                o.DefaultRequestHeaders.Add("apiKey", apiKey);
            })
                .AddTypedClient(c => Refit.RestService.For<ISearchApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IPaxApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IProductApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IProductPricingApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IScheduleApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IPaymentApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IBookingApi>(c))
                .AddTypedClient(c => Refit.RestService.For<IVoucherApi>(c))

            //Add connection resilience policy to httpclient
            .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
            .AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));
            return services;
        }
    }
}
