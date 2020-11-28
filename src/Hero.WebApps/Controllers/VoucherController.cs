using Hero.WebApps.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Controllers
{
    public class VoucherController : Controller
    {
        private readonly IHeroService _heroService;

        public VoucherController(IHeroService heroService)
        {
            _heroService = heroService ?? throw new ArgumentNullException(nameof(heroService));
        }

        [HttpGet]
        public async Task<IActionResult> Index(int bookingId, string paxId)
        {
            var voucherDTO = await _heroService.VoucherApi.GetVoucherAsync(bookingId, paxId);
            return View(voucherDTO);
        }
    }
}
