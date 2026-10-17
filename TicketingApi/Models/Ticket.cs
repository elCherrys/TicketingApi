namespace TicketingApi.Models
{
    public class Ticket
    {

        public int Id { get; init; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public TicketStatus Status { get; set; }
        public TicketPriority Priority { get; set; }
        public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
        public string? Assignee { get; set; }

    }
}
