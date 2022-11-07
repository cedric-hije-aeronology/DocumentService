namespace DocumentService.Models
{
    public class SendTicketRequest : BaseRequest
    {
        public List<string> TicketNumbers { get; set; }
    }
}
