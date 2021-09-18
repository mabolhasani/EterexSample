using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EterexSample.Models
{
    public class LatestRatesResult
    {
        [JsonProperty("data")]
        public IDictionary<string, Currency> Data { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}
