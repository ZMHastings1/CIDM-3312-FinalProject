using Microsoft.EntityFrameworkCore;

namespace CIDM_3312_FinalProject.Models;

public class TicketDbContext : DbContext
{

    public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
    {

    }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Comment> Comments {get; set;}
    public DbSet<Technician> Technicians { get; set; }
    public DbSet<User> Users {get; set;}
}