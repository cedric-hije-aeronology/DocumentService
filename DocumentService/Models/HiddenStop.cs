using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class HiddenStop
    {
        [JsonPropertyName("departure_airport_code")]
        public string AirportCode { get; set; }
    }
}