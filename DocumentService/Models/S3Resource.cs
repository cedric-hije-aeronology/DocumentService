using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class S3Resource
    {
        [JsonPropertyName("resource")]
        public string Resource { get; set; }

        [JsonPropertyName("resourceBucket")]
        public string ResourceBucket { get; set; }

        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    }
}