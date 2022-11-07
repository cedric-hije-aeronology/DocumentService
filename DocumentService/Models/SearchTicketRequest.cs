namespace DocumentService.Models
{
    public class SearchTicketRequest : BaseRequest
    {
        public string Provider { get; set; }

        public string Consolidator { get; set; }

        public string AgentId { get; set; }

        public string UserId { get; set; }

        public string Email { get; set; }

        public string Locator { get; set; }

        public string DocumentNumber { get; set; }

        public decimal PriceItAmount { get; set; }
    }
}
