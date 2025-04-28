namespace EventManagerApi.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
