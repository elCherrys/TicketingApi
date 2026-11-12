using Microsoft.EntityFrameworkCore;
using TicketingApi.Models;
namespace TicketingApi.Data;

public class TicketingDbContext : DbContext
{                                                                                                                                                                                                                                                       
    public TicketingDbContext(
        DbContextOptions<TicketingDbContext> options)
        : base(options) { }

    public DbSet<Ticket> Tickets { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
}                                                                                       