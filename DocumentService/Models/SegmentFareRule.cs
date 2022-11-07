using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class SegmentFareRule
    {
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("fare_rules")]
        public List<FareRule> FareRules { get; set; }
    }
}