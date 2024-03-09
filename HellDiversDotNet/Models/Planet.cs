using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class Planet
    {
        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("hash")]
        public uint Hash { get; set; }

        [JsonPropertyName("index")]
        public uint Index { get; set; }

        [JsonPropertyName("initial_owner")]
        public string InitialOwner { get; set; }

        [JsonPropertyName("max_health")]
        public uint MaxHealth { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("position")]
        public PlanetPosition Position { get; set; }

        [JsonPropertyName("waypoints")]
        public List<uint> Waypoints { get; set; }

        public Planet FromJson(string json)
        {
            return JsonSerializer.Deserialize<Planet>(json);
        }

        public class PlanetPosition
        {
            [JsonPropertyName("x")]
            public float X { get; set; }

            [JsonPropertyName("y")]
            public float Y { get; set; }
        }
    }
}
