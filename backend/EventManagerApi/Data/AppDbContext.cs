using Microsoft.EntityFrameworkCore;
using EventManagerApi.Models.Entities;

namespace EventManagerApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
