namespace TicketingApi.Models
{
    public class Comment
    {
        public Ticket Ticket { get; set; } =null!;
        public int Id { get; init; }
        public int TicketId { get; init; }
        public required string Text { get; set; }
        public required string Author { get; set; }
        public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; }


    }
}
