using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.MessageCategoryDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClient;

        public ContactController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task CategoryDropdown()
        {
            var client = _httpClient.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5123/api/MessageCategory/CategoryList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<List<MessageCategoryDto>>(jsonData);
                ViewBag.categories = (from c in categories
                                      select
                                      new SelectListItem
                                      {
                                          Text = c.MessageCategoryName,
                                          Value = c.MessageCategoryId.ToString(),
                                      }).ToList();
            }
        }

        public async Task<IActionResult> IndexAsync()
        {
            await CategoryDropdown();

            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Now;
            var client = _httpClient.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5123/api/Contact", stringContent);

            return RedirectToAction("Index", "Default");
        }
    }
}
