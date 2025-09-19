using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class BookingByCity : Controller
    {
        public async Task<IActionResult> Index(string cityID)
        {
            if (!string.IsNullOrEmpty(cityID))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    //Url de daha fazla parametre verebilirsin oda sayısı , check-in tarihi, check-out tarihi gibi
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&checkout_date=2025-10-15&dest_type=city&page_number=0&units=metric&order_by=popularity&room_number=1&checkin_date=2025-10-14&filter_by_currency=TRY&dest_id={cityID} &locale=en-gb&include_adjacency=true"),
                    Headers =
    {
        { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?children_number=2&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&checkout_date=2025-10-15&dest_type=city&page_number=0&units=metric&order_by=popularity&room_number=1&checkin_date=2025-10-14&filter_by_currency=TRY&dest_id=-1456928&locale=en-gb&include_adjacency=true"),
                    Headers =
    {
        { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
        { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(values.results.ToList());
                }
            }
        }
    }
}
