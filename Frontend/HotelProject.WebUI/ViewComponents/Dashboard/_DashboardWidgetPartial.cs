using HotelProject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardWidgetPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardWidgetPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5123/api/DashboardWidgets/StaffCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.staffCount = jsonData;
          
            var responseMessage1 = await client.GetAsync("http://localhost:5123/api/DashboardWidgets/BookingCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.bookingCount = jsonData1;

            var responseMessage2 = await client.GetAsync("http://localhost:5123/api/DashboardWidgets/AppUserCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.appUserCount = jsonData2;

            var responseMessage3 = await client.GetAsync("http://localhost:5123/api/DashboardWidgets/RoomCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.roomCount = jsonData3;

            return View();
        }
    }
}
