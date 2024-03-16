using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class PlanetWarStatus
    {
        [JsonPropertyName("health")]
        public uint Health { get; set; }

        [JsonPropertyName("liberation")]
        public float Liberation { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("planet")]
        public Planet Planet { get; set; }

        [JsonPropertyName("players")]
        public uint PlayerCount { get; set; }

        [JsonPropertyName("regen_per_second")]
        public float RegenPerSecond { get; set; }
    }
}
