using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class Error
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("stack")]
        public string Stack { get; set; }
    }
}