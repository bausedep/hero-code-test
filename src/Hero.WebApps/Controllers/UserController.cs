using Hero.WebApps.Consts;
using Hero.WebApps.Models;
using Hero.WebApps.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IHeroService _heroService;

        public UserController(IHeroService heroService)
        {
            _heroService = heroService ?? throw new ArgumentNullException(nameof(heroService));
        }

        [HttpGet]

        public IActionResult SignUp(string returnUrl)
        {
            ViewData[ViewDataKeys.ReturnURL] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpModel signUpViewModel, [FromQuery] string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var paxDTO = await _heroService.PaxApi.CreatePaxAsync(signUpViewModel);
                //Store this to session for testing purpose, on realworld it usually part of authentication process
                HttpContext.Session.SetString(SessionDataKeys.PaxId, paxDTO.Id);
                HttpContext.Session.SetString(SessionDataKeys.MyName, signUpViewModel.First);
                if (returnUrl == null)
                {
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    return Redirect(returnUrl);

                }
            }
            return View();
        }

    }
}
