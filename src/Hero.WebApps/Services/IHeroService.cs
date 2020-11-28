using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Services
{
    public interface IHeroService
    {
        public ISearchApi SearchApi { get; }
        public IPaxApi PaxApi { get; }
    }
}
