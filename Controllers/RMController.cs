using Microsoft.AspNetCore.Mvc;
using MovieMVCDemo.Models;

namespace MovieMVCDemo.Controllers
{
    public class RMController : Controller
    {
        private readonly HttpClient _client;

        public RMController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("RickAndMortyApi");
        }

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync("character/1");

            if (response.IsSuccessStatusCode)
            {
                var character = await response.Content.ReadFromJsonAsync<RickAndMortyCharacter>();

                return View(character);
            }

            return View();
        }
    }
}
