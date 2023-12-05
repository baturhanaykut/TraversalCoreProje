using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingHotelSearhController : Controller
    {
        public async Task<IActionResult> Index()
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                //RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-1456928&search_type=CITY&arrival_date=2023-12-15&departure_date=2023-12-30&adults=1&children_age=0%2C17&room_qty=1&page_number=1&languagecode=en-us&currency_code=EUR"),
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&order_by=popularity&filter_by_currency=TRY&adults_number=2&room_number=1&dest_id=-1456928&checkout_date=2024-05-20&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&children_ages=5%2C0&children_number=2"),
                Headers =
    {
        { "X-RapidAPI-Key", "6e34ec937dmsh9356cb92ef98cbap1ab591jsnbbb9a85c3e5f" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingHotelSearcViewModel.Rootobject>(body);
                return View(values.results);
            }

        }

        [HttpGet]
        public IActionResult GetCityDestId()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityDestId(string p)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "6e34ec937dmsh9356cb92ef98cbap1ab591jsnbbb9a85c3e5f" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View();
            }
        }

    }
}
