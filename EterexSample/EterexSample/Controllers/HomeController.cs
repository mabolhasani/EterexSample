using EterexSample.Settings;
using Microsoft.AspNetCore.Mvc;
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
            await _coinmarketcapClient.LatestRates(coinMarketCapId);

            return Ok();
        }
    }
}
