﻿using Newtonsoft.Json;
using System;

namespace EterexSample.Models
{
    public class Quote
    {
        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("volume_24h")]
        public double Volume24h { get; set; }

        [JsonProperty("percent_change_1h")]
        public double PercentChange1h { get; set; }

        [JsonProperty("percent_change_24h")]
        public double PercentChange24h { get; set; }

        [JsonProperty("percent_change_7d")]
        public double PercentChange7d { get; set; }

        [JsonProperty("percent_change_30d")]
        public object PercentChange30d { get; set; }

        [JsonProperty("percent_change_60d")]
        public object PercentChange60d { get; set; }

        [JsonProperty("percent_change_90d")]
        public object PercentChange90d { get; set; }

        [JsonProperty("market_cap")]
        public int MarketCap { get; set; }

        [JsonProperty("market_cap_dominance")]
        public int MarketCapDominance { get; set; }

        [JsonProperty("fully_diluted_market_cap")]
        public int FullyDilutedMarketCap { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
    }
}
