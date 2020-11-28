using Hero.Service.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface ISearchApi
    {
        [Get("/Search?q={q}&lat=2&lng=41")]
        Task<IEnumerable<SearchDTO>> GetCatalogAsync([Query] string q, [Query] double lat, [Query] double lng);
    }
}
