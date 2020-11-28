using Hero.Service.DTO;
using Hero.WebApps.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IPaxApi
    {
        [Post("/pax")]
        Task<PaxDTO> CreatePaxAsync([Body] SignUpModel signUpModel);

    }
}
