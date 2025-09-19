using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ResultInstagramFollowersDto resultInstagramFollowersDtos = new ResultInstagramFollowersDto();

            //var client = new HttpClient();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/khabib_nurmagomedov"),
            //    Headers =
            //    {
            //        { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
            //        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
            //    },
            //};
            //using (var response = await client.SendAsync(request))
            //{
            //    response.EnsureSuccessStatusCode();
            //    var body = await response.Content.ReadAsStringAsync();
            //    resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
            //    ViewBag.v1 = resultInstagramFollowersDtos.followers;
            //    ViewBag.v2 = resultInstagramFollowersDtos.following;
            //}

            //var client1 = new HttpClient();
            //var request1 = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://twitter32.p.rapidapi.com/profile?username=murattyucedag"),
            //    Headers =
            //    {
            //        { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
            //        { "x-rapidapi-host", "twitter32.p.rapidapi.com" },
            //    },
            //};
            //using (var response1 = await client.SendAsync(request1))
            //{
            //    response1.EnsureSuccessStatusCode();
            //    var body1 = await response1.Content.ReadAsStringAsync();
            //    var resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto.Rootobject>(body1);

            //    if (resultTwitterFollowersDto?.data?.stats != null)
            //    {
            //        ViewBag.v3 = resultTwitterFollowersDto.data.stats.followers;
            //        ViewBag.v4 = resultTwitterFollowersDto.data.stats.following;
            //    }
            //    else
            //    {
            //        ViewBag.v3 = "0";
            //        ViewBag.v4 = "0";
            //    }

            //}

            return View();
        }
    }
}
