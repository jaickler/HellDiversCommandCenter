using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class WarStatus
    {
        [JsonPropertyName("active_election_policy_effects")]
        public List<uint>? ActiveElectionPolicyEffects { get; set; }

        [JsonPropertyName("campaigns")]
        public List<Campaign>? Campaigns { get; set; }

        [JsonPropertyName("community_targets")]
        public List<uint>? CommunityTargets { get; set; }

        [JsonPropertyName("global_events")]
        public List<Event>? GlobalEvents { get; set; }

        [JsonPropertyName("impact_multiplier")]
        public float? ImpactMultiplier { get; set; }

        [JsonPropertyName("joint_operations")]
        public List<JointOperation>? JointOperations { get; set; }

        [JsonPropertyName("planet_active_effects")]
        public List<uint>? PlanetActiveEffects { get; set; }

        [JsonPropertyName("planet_attacks")]
        public List<PlanetAttack>? PlanetAttacks { get; set; }

        [JsonPropertyName("planet_events")]
        public List<PlanetEvent>? PlanetEvents { get; set; }

        [JsonPropertyName("planet_status")]
        public List<PlanetWarStatus>? PlanetWarStatuses { get; set; }

        [JsonPropertyName("snapshot_at")]
        public DateTime? LastUpdated { get; set; }

        [JsonPropertyName("war_id")]
        public uint? WarId { get; set; }

        public WarStatus FromJson(string json)
        {
            return JsonSerializer.Deserialize<WarStatus>(json);
        }
    }
}
