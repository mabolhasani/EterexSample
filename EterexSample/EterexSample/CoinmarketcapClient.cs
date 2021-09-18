using EterexSample.Models;
using EterexSample.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace EterexSample
{
    public class CoinmarketcapClient
    {
        private readonly HttpClient _client;

        public CoinmarketcapClient(CoinmarketcapConfig config)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(config.BaseAddress)
            };

            _client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", config.AccessKey);
            _client.DefaultRequestHeaders.Add("Accepts", "application/json");
        }

        public async Task<HttpResponseMessage> LatestRates(int coinMarketCapId)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            query["id"] = coinMarketCapId.ToString();
            query["convert"] = "EUR";

            return await _client.GetAsync($"cryptocurrency/quotes/latest?{query}");
        }
    }
}
