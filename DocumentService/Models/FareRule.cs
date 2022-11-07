using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class FareRule
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}