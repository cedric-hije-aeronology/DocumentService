using System.Text.Json.Serialization;

namespace DocumentService.Models
{
    public class Segment
    {
        [JsonPropertyName("departure_airport_code")]
        public string DepartureAirportCode { get; set; }

        [JsonPropertyName("departure_aiport_name")]
        public string DepartureAirportName { get; set; }

        [JsonPropertyName("departure_terminal")]
        public string DepartureTerminal { get; set; }

        [JsonPropertyName("departure_date_text")]
        public string DepartureDateText { get; set; }

        [JsonPropertyName("arrival_airport_code")]
        public string ArrivalAirportCode { get; set; }

        [JsonPropertyName("arrival_airport_name")]
        public string ArrivalAirportName { get; set; }

        [JsonPropertyName("arrival_terminal")]
        public string ArrivalTerminal { get; set; }

        [JsonPropertyName("arrival_date_text")]
        public string ArrivalDateText { get; set; }

        [JsonPropertyName("hidden_stops")]
        public List<HiddenStop> HiddenStops { get; set; }

        [JsonPropertyName("special_service_request")]
        public List<SpecialServiceRequest> SpecialServiceRequests { get; set; }

        [JsonPropertyName("airline_name")]
        public string AirlineName { get; set; }

        [JsonPropertyName("carrier_code")]
        public string CarrierCode { get; set; }

        [JsonPropertyName("flight_number")]
        public string FlightNumber { get; set; }

        [JsonPropertyName("operating_carrier_name")]
        public string OperatingCarrierName { get; set; }

        [JsonPropertyName("cabin")]
        public string Cabin { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("distance_in_miles")]
        public string DistanceInMiles { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("equipment")]
        public string Equipment { get; set; }

        [JsonPropertyName("ancillaries")]
        public List<Ancillary> Ancillaries { get; set; }
    }
}