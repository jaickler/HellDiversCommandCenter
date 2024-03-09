using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class Event
    {
        [JsonPropertyName("assignment_id_32")]
        public uint AssignemntID { get; set; }

        [JsonPropertyName("effects")]
        public List<string> Effects { get; set; }

        [JsonPropertyName("flag")]
        public ushort Flag { get; set; }

        [JsonPropertyName("id")]
        public uint Id { get; set; }

        [JsonPropertyName("id_32")]
        public uint Id32 { get; set; }

        [JsonPropertyName("message")]
        public Dictionary<string, string> Message { get; set; }

        [JsonPropertyName("message_id_32")]
        public uint MessageId32 { get; set; }

        [JsonPropertyName("planets")]
        public List<uint> PlanetIds { get; set; }

        [JsonPropertyName("portrait_id_32")]
        public uint PortraitId32 { get; set; }

        [JsonPropertyName("race")]
        public string Race {  get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("title_32")]
        public uint TitleID { get; set; }

        public Event FromJson(string json)
        {
            return JsonSerializer.Deserialize<Event>(json)!;
        }
    }
}
