namespace EventManagerApi.Models.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string BuyerName { get; set; } = string.Empty;

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
