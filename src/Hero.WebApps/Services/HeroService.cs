using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public class HeroService :IHeroService
    {
        private readonly HttpClient _httpClient;
        public ISearchApi SearchApi { get; }
        public HeroService(HttpClient httpClient, ISearchApi searchApi)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            SearchApi = searchApi ?? throw new ArgumentNullException(nameof(searchApi));
        }
    }
}
