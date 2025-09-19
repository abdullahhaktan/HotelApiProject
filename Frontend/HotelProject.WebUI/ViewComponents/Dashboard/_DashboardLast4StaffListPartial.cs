using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast4StaffListPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4StaffListPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5123/api/Staff/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        //[HttpGet]
        //public async Task<IViewComponentResult> AddGuest()
        //{
        //    return View();
        //}

        ////[HttpPost]
        ////public async Task<IViewComponentResult> AddGuest(CreateGuestDto createGuestDto)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        var client = _httpClientFactory.CreateClient();
        ////        var jsonData = JsonConvert.SerializeObject(createGuestDto);
        ////        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        ////        var responseMessage = await client.PostAsync("http://localhost:5123/api/Guest", stringContent);
        ////        if (responseMessage.IsSuccessStatusCode)
        ////        {
        ////            return RedirectToAction("Index");
        ////        }
        ////        else
        ////        {
        ////            return View();
        ////        }
        ////    }
        ////    else
        ////    {
        ////        return View();
        ////    }

        ////}
        ////public async Task<IViewComponentResult> DeleteGuest(int id)
        ////{
        ////    var client = _httpClientFactory.CreateClient();
        ////    var responseMessage = await client.DeleteAsync($"http://localhost:5123/api/Guest/{id}");
        ////    if (responseMessage.IsSuccessStatusCode)
        ////    {
        ////        return RedirectToAction("Index");
        ////    }
        ////    return View();
        ////}
        //[HttpGet]
        //public async Task<IViewComponentResult> UpdateGuest(int id)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responseMessage = await client.GetAsync($"http://localhost:5123/api/Guest/{id}"); //Guest?id={id} yazarak da olur du
        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        //        var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);
        //        return View(values);
        //    }
        //    return View();
        //}

        //[HttpPost]
        ////public async Task<IViewComponentResult> UpdateGuest(UpdateGuestDto updateGuestDto)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        var client = _httpClientFactory.CreateClient();
        ////        var jsonData = JsonConvert.SerializeObject(updateGuestDto);
        ////        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        ////        var responseMessage = await client.PutAsync($"http://localhost:5123/api/Guest/", stringContent);
        ////        if (responseMessage.IsSuccessStatusCode)
        ////        {
        ////            return RedirectToAction("Index");
        ////        }
        ////        else
        ////        {
        ////            return View();
        ////        }
        ////    }

        ////    return View();
        ////}
    }
}
