﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
                    { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(apiMovieViewModels);
            }
        }
    }
}
