using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class SpecialServiceRequest
    {
        [JsonPropertyName("type")]
        public SSRType Type { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("seat_number")]
        public string SeatNumber { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public enum SSRType
    {
        Meal,
        Medical,
        Passenger,
        Baggage,
        Seat,
        Lounge,
        InflightEntertainment,
        Loyalty,
        TBC,
        PDUM,
        Other
    }
}