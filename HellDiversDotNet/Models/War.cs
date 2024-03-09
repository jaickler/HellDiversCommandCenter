using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class War
    {
        [JsonPropertyName("capitals")]
        public List<uint> Capitals {  get; set; }

        [JsonPropertyName("end_date")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("home_worlds")]
        public List<HomeWorld?> HomeWorlds { get; set; }


        [JsonPropertyName("minimum_client_version")]
        public string MinimumClientVersion { get; set; }

        [JsonPropertyName("planet_permanent_effects")]
        public List<uint?> PlanetPermanentEffectIds { get; set; }

        [JsonPropertyName("planets")]
        public List<Planet> Planets { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("war_id")]
        public uint WarId { get; set; }


        public War FromJson(string json)
        {
            return JsonSerializer.Deserialize<War>(json);
        }
    }
}
