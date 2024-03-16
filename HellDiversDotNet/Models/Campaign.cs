using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class Campaign
    {
        [JsonPropertyName("count")]
        public uint? Count { get; set; }

        [JsonPropertyName("id")]
        public uint? Id { get; set; }

        [JsonPropertyName("planet")]
        public Planet? Planet { get; set; }

        [JsonPropertyName("type")]
        public uint? Type { get; set; }

        public Campaign FromJson(string json)
        {
            return JsonSerializer.Deserialize<Campaign>(json);
        }
    }
}
