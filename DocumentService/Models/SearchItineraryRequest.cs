using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class SearchItineraryRequest : BaseRequest
    {
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        [JsonPropertyName("consolidator")]
        public string Consolidator { get; set; }

        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("locator")]
        public string Locator { get; set; }

        [JsonPropertyName("document_number")]
        public string DocumentNumber { get; set; }

        [JsonPropertyName("price_it_amount")]
        public decimal PriceItAmount { get; set; }
    }
}
