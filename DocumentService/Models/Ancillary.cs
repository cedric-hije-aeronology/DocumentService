using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class Ancillary
    {
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("carrier_code")]
        public string CarrierCode { get; set; }

        [JsonPropertyName("seat_number")]
        public string SeatNumber { get; set; }
    }
}