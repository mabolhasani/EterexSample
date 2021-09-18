using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EterexSample.Models
{
    public class Currency
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("timestamp")]
        public string slug { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("is_fiat")]
        public bool IsFiat { get; set; }

        [JsonProperty("circulating_supply")]
        public int CirculatingSupply { get; set; }

        [JsonProperty("total_supply")]
        public int TotalSupply { get; set; }

        [JsonProperty("max_supply")]
        public int? MaxSupply { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("num_market_pairs")]
        public int NumMarketPairs { get; set; }

        [JsonProperty("cmc_rank")]
        public int? CmcRank { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("quote")]
        public IDictionary<string, Quote> Quote { get; set; }
    }
}
