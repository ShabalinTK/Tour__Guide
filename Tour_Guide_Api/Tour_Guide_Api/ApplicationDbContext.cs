using Tour_Guide_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tour_Guide_Api;

public class ApplicationDbContext : DbContext
{
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Comment> Comment { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
