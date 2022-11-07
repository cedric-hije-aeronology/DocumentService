using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class GenerateItineraryResponse : BaseResponse
    {
        [JsonPropertyName("body")]
        public S3Resource Body { get; set; }

        [JsonPropertyName("status_code")]
        public System.Net.HttpStatusCode StatusCode { get; set; }

        [JsonPropertyName("document_number")]
        public string DocumentNumber { get; set; }
    }
}
