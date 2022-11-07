namespace DocumentService.Models
{
    public class GenerateItineraryRequest : BaseRequest
    {
        public string Provider { get; set; }

        public string Consolidator { get; set; }

        public string AgentId { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string Locator { get; set; }

        public Dictionary<string, string> // ticketNumber, priceItAmount
    }
}
