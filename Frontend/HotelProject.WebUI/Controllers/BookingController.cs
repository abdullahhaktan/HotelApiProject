using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClient;

        public BookingController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.Status = "Onay Bekliyor";
            createBookingDto.Description = "fdsfasfda";

            var client = _httpClient.CreateClient();

            // Configure JsonSerializerSettings to use ISO 8601 format for DateTime.
            //var settings = new JsonSerializerSettings
            //{
            //    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
            //};

            var jsonData = JsonConvert.SerializeObject(createBookingDto/*, settings*/);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("http://localhost:5123/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            // You can log the error details for debugging if the request fails
            var errorContent = await responseMessage.Content.ReadAsStringAsync();

            return View();
        }
    }
}
