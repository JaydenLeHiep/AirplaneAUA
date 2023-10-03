using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FlightsController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            string apiUrl = "https://airlabs.co/api/v9/flights?api_key=99132d97-bff2-4485-87a6-529ee997523e&airline_icao=AUA";

            var response = await client.GetStringAsync(apiUrl);

            JObject parsedData = JObject.Parse(response);

            // Use null conditional operator to avoid possible null reference
            JArray? flightsArray = parsedData?["response"] as JArray;

            if (flightsArray == null)
            {
                return View("Error", new { message = "Unable to fetch flights data" });
            }

            List<AirlineFlight> flightsList = flightsArray.ToObject<List<AirlineFlight>>();

            // Now you have the flights in the flightsList. You can pass this to a view or use as needed.

            return View(flightsList); // For example, passing it to a view.
        }
    }
}
