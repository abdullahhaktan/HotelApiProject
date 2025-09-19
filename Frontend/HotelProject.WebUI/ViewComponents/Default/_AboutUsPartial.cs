using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClient;

        public _AboutUsPartial(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClient.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5123/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
