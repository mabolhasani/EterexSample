using EterexSample.Models;
using EterexSample.Settings;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace EterexSample.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly CoinmarketcapClient _coinmarketcapClient;

        public HomeController(CoinmarketcapConfig coinmarketcapConfig)
        {
            _coinmarketcapClient = new CoinmarketcapClient(coinmarketcapConfig);
        }

        [HttpGet("{coinMarketCapId:int}")]
        public async Task<IActionResult> Index(int coinMarketCapId)
        {
            var response = await _coinmarketcapClient.LatestRates(coinMarketCapId);

            var result = JsonConvert.DeserializeObject<LatestRatesResult>(
                    await response.Content.ReadAsStringAsync());

            return response.StatusCode switch
            {
                HttpStatusCode.OK => Ok(result),
                HttpStatusCode.BadRequest => BadRequest(result),
                HttpStatusCode.Unauthorized => Unauthorized(result),
                _ => throw new ArgumentOutOfRangeException("Not implemented yet!"),
            };
        }
    }
}
