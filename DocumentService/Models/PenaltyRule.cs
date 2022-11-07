using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class PenaltyRule
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }
    }
}