using Tour_Guide_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tour_Guide_Api;

public class ApplicationDbContext : DbContext
{
    public DbSet<Tour> Tours { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tour>(entity =>
        {
            // Настройки строковых полей
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.Theme)
                .HasMaxLength(50);

            entity.Property(e => e.ImageUrls)
                .HasColumnType("text");

            entity.Property(e => e.Description)
                .HasColumnType("text");

            // Настройки для полей со списками (хранимых как text)
            entity.Property(e => e.Activities)
                .HasColumnType("text");

            entity.Property(e => e.Includes)
                .HasColumnType("text");

            entity.Property(e => e.NotIncludes)
                .HasColumnType("text");

            entity.Property(e => e.Safety)
                .HasColumnType("text");

            entity.Property(e => e.Languages)
                .HasColumnType("text");

            entity.Property(e => e.Duration)
                .HasMaxLength(50);

            entity.Property(e => e.NumberOfPeople)
                .HasMaxLength(50);

            entity.Property(e => e.Address)
                .HasColumnType("text");

            // Настройки числовых полей
            entity.Property(e => e.Price)
                .IsRequired();

            entity.Property(e => e.Reviews)
                .HasDefaultValue(0);
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasIndex(e => e.TourId);

            // Дополнительные настройки для Comment
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.AvatarUrl)
                .HasColumnType("text");

            entity.Property(e => e.CommentDate)
                .HasColumnType("varchar(20)");

            entity.Property(e => e.Text)
                .HasColumnType("text")
                .IsRequired();

            entity.Property(e => e.Rating)
                .IsRequired();
        });
    }
}
