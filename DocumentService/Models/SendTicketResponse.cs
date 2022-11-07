namespace DocumentService.Models
{
    public class SendTicketResponse : BaseResponse
    {
        public List<Itinerary> Itineraries { get; set; }
    }
}
