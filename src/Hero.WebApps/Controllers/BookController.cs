using Hero.Service.DTO;
using Hero.WebApps.Consts;
using Hero.WebApps.Extensions;
using Hero.WebApps.Models;
using Hero.WebApps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Controllers
{
    public class BookController : Controller
    {
        private readonly IHeroService _heroService;

        public BookController(IHeroService heroService)
        {
            _heroService = heroService ?? throw new ArgumentNullException(nameof(heroService));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">The product id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            //Should be part of authorization attribute, just for this demo it's ok
            string paxId = HttpContext.Session.GetString(SessionDataKeys.PaxId);
            if (paxId == null)
            {
                string returnUrl = HttpContext.Request.Path;
                return RedirectToAction("SignUp", "User", new { returnUrl });
            }
            else
            {
                var product = await _heroService.ProductApi.GetProductAsync(id);
                // Not clear, no data found on the staging and not enough explanation from business perspective
                var schedules = await _heroService.ScheduleApi.GetSchedulesAsync(id, DateTime.UtcNow.ToString("yyyy-MM-dd"));

                BookViewModel bookViewModel = new BookViewModel(product, schedules);
                HttpContext.Session.SetString(SessionDataKeys.MyBook, JsonConvert.SerializeObject(bookViewModel));
                return View(bookViewModel);
            }

        }


        [HttpPost]
        public async Task<IActionResult> CheckPrice(CheckPriceViewModel checkPriceViewModel)
        {
            string sessionBook = HttpContext.Session.GetString(SessionDataKeys.MyBook);
            BookViewModel bookViewModel = JsonConvert.DeserializeObject<BookViewModel>(sessionBook);
            ProductPriceDTO productPriceDTO = await getProductPricing(bookViewModel.ProductId, checkPriceViewModel.CheckInDate, checkPriceViewModel.CheckInTime);
            bookViewModel.CalculateFinalPrice(productPriceDTO);

            var priceSnapShot = new
            {
                DiscountAmount = $"{bookViewModel.Currency} {bookViewModel.DiscountAmount}",
                FinalPrice = $"{bookViewModel.Currency} {bookViewModel.FinalPrice}",
                OriginalPrice = $"{bookViewModel.Currency} {bookViewModel.OriginalPrice}",
            };
            return Json(priceSnapShot);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(BookViewModel bookViewModel)
        {
            if (ModelState.IsValid)
            {

                string paxId = HttpContext.Session.GetString(SessionDataKeys.PaxId);

                //Calculate Product Price
                ProductPriceDTO productPrice = await getProductPricing(bookViewModel.ProductId, bookViewModel.CheckInDate, bookViewModel.CheckInTime);
                bookViewModel.CalculateFinalPrice(productPrice);

                //Create Booking
                CreateBookingCommand createBookingCommand = new CreateBookingCommand
                {
                    Name = bookViewModel.ProductName
                };
                CreateBookingCommandItem bookingItem = new CreateBookingCommandItem()
                {
                    ProductId = bookViewModel.ProductId,
                    DateCheckIn = bookViewModel.CheckInDate.ToJsonDateTime(bookViewModel.CheckInTime),
                };
                bookingItem.PaxId.Add(paxId);
                createBookingCommand.BookingProducts.Add(bookingItem);
                BookingProductDTO bookingProductDTO = await _heroService.BookingApi.CreateBookingAsync(createBookingCommand);

                //Validate Booking
                BookingValidationResultDTO bookResult = await _heroService.BookingApi.ValidateBookingAsync(bookingProductDTO.Id);
                if (bookResult.IsValid)
                {
                    //Create the payment
                    CreatePaymentCommand createPaymentCommand = new CreatePaymentCommand()
                    {
                        Amount = bookViewModel.FinalPrice,
                        BookingId = bookingProductDTO.Id,
                        IsFinal = true,
                        Method = PaymentMethod.Cash,
                        PaxId = paxId
                    };
                    await _heroService.PaymentApi.CreatePaymentAsync(createPaymentCommand);
                    return RedirectToAction("Index", "Voucher", new { bookingId = bookingProductDTO.Id, paxId });
                }
                else
                {
                    this.ModelState.AddModelError("BookValidation", "Book validation failed please retry");
                }


            }
            return View(bookViewModel);
        }

        private async Task<ProductPriceDTO> getProductPricing(int productId, string checkinDate, string checkinTime)
        {
            //Finalize the booking state and recalculate the pricing (validate price in the backend)
            return await _heroService
                        .ProductPricingApi
                        .GetProductPriceAsync(productId, checkinDate.ToJsonDateTime(checkinTime));
        }


    }
}
