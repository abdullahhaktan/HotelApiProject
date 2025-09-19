using HotelProject.WebUI.Dtos.AdminContactDto;
using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task valuesAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage2 = await client.GetAsync("http://localhost:5123/api/Contact/GetContactCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                ViewBag.contactCount = jsonData2;
            }
            var responseMessage3 = await client.GetAsync("http://localhost:5123/api/Contact/GetSendMessageCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                ViewBag.sendMessageCount = jsonData3;
            }
        }

        public async Task<IActionResult> Inbox()
        {
            await valuesAsync();

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5123/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                return View(values);
            }
            return View();

        }

        public async Task<IActionResult> SendBox()
        {
            await valuesAsync();

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5123/api/SendMessage");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddAdminContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAdminContact(CreateSendMessageDto createSendMessageDto)
        {
            createSendMessageDto.SenderMail = "admin@gmail.com";
            createSendMessageDto.SenderName = "Admin";
            createSendMessageDto.Date = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessageDto);
            StringContent stringContent = new  StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5123/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Inbox");
            }
            return View();
        }

        public PartialViewResult SideBarAdminContactPartial()
        {
            return PartialView()
;       }

        public PartialViewResult SideBarAdminCategoryContactPartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> MessageDetails(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5123/api/SendMessage/{id}"); 
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ChangeIsRead(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5123/api/Contact/ChangeMessageId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Inbox");
            }
            return View();
        }

    }
}
