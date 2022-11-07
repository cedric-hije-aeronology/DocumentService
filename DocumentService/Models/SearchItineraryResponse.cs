namespace DocumentService.Models
{
    public class SearchItineraryResponse
    {
        public List<Ticket> Tickets { get; set; }

        public bool IsApiDown { get; set; }
    }
}
