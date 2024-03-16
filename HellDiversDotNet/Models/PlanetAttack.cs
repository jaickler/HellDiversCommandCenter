using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class PlanetAttack
    {
        [JsonPropertyName("source")]
        public Planet? Source { get; set; }

        [JsonPropertyName("target")]
        public Planet? Target { get; set; }

        public PlanetAttack FromJson(string json)
        {
            return JsonSerializer.Deserialize<PlanetAttack>(json);
        }
    }
}