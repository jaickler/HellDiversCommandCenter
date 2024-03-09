using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class HomeWorld
    {
        [JsonPropertyName("planets")]
        public List<Planet> Planets { get; set; }

        [JsonPropertyName("race")]
        public string Race { get; set; }

        public HomeWorld? FromJson(string json)
        {
            return JsonSerializer.Deserialize<HomeWorld>(json);
        }
    }
}
