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

        public War FromJson(string json)
        {
            return JsonSerializer.Deserialize<War>(json);
        }
    }
}
