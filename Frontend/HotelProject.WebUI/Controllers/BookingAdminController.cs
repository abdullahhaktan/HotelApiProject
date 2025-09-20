using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5123/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApproveBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var getResponse = await client.GetAsync($"http://localhost:5123/api/Booking/{id}");
            if (getResponse.IsSuccessStatusCode)
            {
                var jsonData = await getResponse.Content.ReadAsStringAsync();
                var booking = JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                booking.Status = "Onaylandı";
                var updateJsonData = JsonConvert.SerializeObject(booking);
                StringContent stringContent = new StringContent(updateJsonData,Encoding.UTF8, "application/json");

                await client.PutAsync($"http://localhost:5123/api/Booking/", stringContent);

                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> CancelBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var getResponse = await client.GetAsync($"http://localhost:5123/api/Booking/{id}");
            if (getResponse.IsSuccessStatusCode)
            {
                var jsonData = await getResponse.Content.ReadAsStringAsync();
                var booking = JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                booking.Status = "İptal Edildi";
                var updateJsonData = JsonConvert.SerializeObject(booking);
                StringContent stringContent = new StringContent(updateJsonData, Encoding.UTF8, "application/json");

                await client.PutAsync($"http://localhost:5123/api/Booking/", stringContent);

                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> ChangeToCall(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var getResponse = await client.GetAsync($"http://localhost:5123/api/Booking/{id}");
            if(getResponse.IsSuccessStatusCode)
            {
                var jsonData = await getResponse.Content.ReadAsStringAsync();
                var booking = JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                booking.Status = "Müşteri Aranacak";
                var updateJsonData = JsonConvert.SerializeObject(booking);
                StringContent stringContent = new StringContent(updateJsonData, Encoding.UTF8, "application/json");

                await client.PutAsync($"http://localhost:5123/api/Booking/", stringContent);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> ChangeToWait(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var getResponse = await client.GetAsync($"http://localhost:5123/api/Booking/{id}");
            if (getResponse.IsSuccessStatusCode)
            {
                var jsonData = await getResponse.Content.ReadAsStringAsync();
                var booking = JsonConvert.DeserializeObject<ResultBookingDto>(jsonData);
                booking.Status = "Onay bekliyor";
                var updateJsonData = JsonConvert.SerializeObject(booking);
                StringContent stringContent = new StringContent(updateJsonData, Encoding.UTF8, "application/json");

                await client.PutAsync($"http://localhost:5123/api/Booking/", stringContent);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5123/api/Booking/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var client = _httpClientFactory.CreateClient();

            //var settings = new JsonSerializerSettings
            //{
            //    DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ"
            //};

            var jsonData = JsonConvert.SerializeObject(updateBookingDto /*, settings*/);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // JSON verisini debug için yazdır
            Console.WriteLine("Gönderilen JSON:");
            Console.WriteLine(jsonData);

            var responseMessage = await client.PutAsync($"http://localhost:5123/api/Booking", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            // HATA DETAYLARINI MUTLAKA OKUYUN
            var errorContent = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine($"HTTP Status: {(int)responseMessage.StatusCode} {responseMessage.StatusCode}");
            Console.WriteLine($"Hata Detayı: {errorContent}");

            // Hata mesajını View'a taşı
            ViewBag.ErrorMessage = errorContent;
            return View(updateBookingDto);
        }
        
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.DeleteAsync($"http://localhost:5123/api/Booking/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
