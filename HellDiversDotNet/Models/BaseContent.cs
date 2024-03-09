using System.Text.Json;
using System.Text.Json.Serialization;

namespace HellDiversDotNet.Models
{
    public class BaseContent
    {
        [JsonPropertyName("current")]
        public UInt16 CurrentSeason { get; set; }
        [JsonPropertyName("seasons")]
        public List<UInt16> Seasons { get; set; }


        public static BaseContent FromJson(string json)
        {
            // Use JsonSerializer.Deserialize method to deserialize JSON into MyClass object
            return JsonSerializer.Deserialize<BaseContent>(json)!;
        }

        BaseContent(UInt16 currentSeason, List<UInt16> seasons)
        {
            CurrentSeason = currentSeason;
            Seasons = seasons;
        }

        [JsonConstructorAttribute]
        BaseContent()
        {
            
        }
    }
}
