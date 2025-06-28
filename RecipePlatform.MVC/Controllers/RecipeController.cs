using Microsoft.AspNetCore.Mvc;
using RecipePlatform.MVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace RecipePlatform.MVC.Controllers
{
    public class RecipeController : Controller
    {
        private readonly HttpClient _httpClient;

        public RecipeController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7217/api/");
        }

        public async Task<IActionResult> Index()
        {
            var recipes = await _httpClient.GetFromJsonAsync<List<RecipeDto>>("recipes");
            if (recipes == null)
                recipes = new List<RecipeDto>();

            return View(recipes);
        }
    }
}
