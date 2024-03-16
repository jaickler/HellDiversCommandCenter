using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class JointOperation
    {
        [JsonPropertyName("hq_node_index")]
        public uint? HqNodeIndex { get; set; }

        [JsonPropertyName("id")]
        public uint? Id { get; set; }

        [JsonPropertyName("planet")]
        public Planet? Planet { get; set; }

        public JointOperation FromJson(string json)
        {
            return JsonSerializer.Deserialize<JointOperation>(json);
        }
    }
}