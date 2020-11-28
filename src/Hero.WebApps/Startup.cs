using Hero.WebApps.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // the AddHttpClient() will provide us with an instance of HttpClient
            // available for Dependancy Injection in our services
            services.AddHttpClient<IHeroService, HeroService>(o =>
            {
                string heroApiAddress = Configuration["HeroApiAddress"] ?? throw new ArgumentNullException("Hero api address is not set");
                string apiKey = Configuration["ApiKey"] ?? throw new ArgumentNullException("Hero api key is not set");
                o.BaseAddress = new Uri(heroApiAddress);
                o.DefaultRequestHeaders.Add("apiKey", apiKey);
            })
             .AddTypedClient(c => Refit.RestService.For<ISearchApi>(c))
            
             //Add connection resilience to httpclient
            .AddTransientHttpErrorPolicy(p => p.RetryAsync(3))
            .AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

            bool useFakeService = Configuration.GetValue<bool>("UseFake");
            if (useFakeService)
            {
                services.AddSingleton<ISearchApi, FakeSearchApi>();
            }

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }



    }
    public static class StartupExtension
    {
        public static IServiceCollection AddFakeService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISearchApi, FakeSearchApi>();
            return services;
        }
    }



}
