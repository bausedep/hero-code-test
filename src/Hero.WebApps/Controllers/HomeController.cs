using Hero.WebApps.Models;
using Hero.WebApps.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHeroService _heroService;

        public HomeController(ILogger<HomeController> logger, IHeroService heroService)
        {
            _logger = logger;
            _heroService = heroService ?? throw new ArgumentNullException(nameof(heroService));
        }

        [HttpGet]
        public async Task<IActionResult> Index(string q = "reef")
        {
            if (q == null)
            {
                return View();
            }
            else
            {
                var searchResults = await _heroService.SearchApi.GetCatalogAsync(q, 1, 1);
                return View(searchResults);
            }

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
