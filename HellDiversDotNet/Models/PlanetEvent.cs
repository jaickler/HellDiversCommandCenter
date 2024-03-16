using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class PlanetEvent
    {
        [JsonPropertyName("campaign")]
        public Campaign? Campaign { get; set; }

        [JsonPropertyName("event_type")]
        public uint? EventType { get; set; }

        [JsonPropertyName("expire_time")]
        public DateTime? ExpireTime { get; set; }

        [JsonPropertyName("health")]
        public uint? Health { get; set; }

        [JsonPropertyName("id")]
        public uint? Id { get; set; }

        [JsonPropertyName("joint_operations")]
        public List<JointOperation>? JointOperations { get; set; }

        [JsonPropertyName("max_health")]
        public uint? MaxHealth { get; set; }

        [JsonPropertyName("planet")]
        public Planet? Planet { get; set; }

        [JsonPropertyName("race")]
        public string? Race { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        public PlanetEvent FromJson(string json)
        {
            return JsonSerializer.Deserialize<PlanetEvent>(json);
        }
    }
}