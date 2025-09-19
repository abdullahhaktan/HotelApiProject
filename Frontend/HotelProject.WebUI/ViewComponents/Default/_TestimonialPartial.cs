using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.TestimonialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _TestimonialPartial:ViewComponent
    {
        public readonly IHttpClientFactory _httpClient;

        public _TestimonialPartial(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClient.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5123/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestiomonialDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
