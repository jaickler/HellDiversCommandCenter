using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class WarInfo
    {
        [JsonPropertyName("capitals")]
        public List<uint> Capitals {  get; set; }

        [JsonPropertyName("end_date")]
        public DateTime EndDate { get; set; }

        public WarInfo FromJson(string json)
        {
            return JsonSerializer.Deserialize<WarInfo>(json);
        }
    }
}
