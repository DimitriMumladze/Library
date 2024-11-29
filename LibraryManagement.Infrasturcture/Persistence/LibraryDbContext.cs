using Microsoft.EntityFrameworkCore;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Infrasturcture.Persistence;

internal class BookManagementDbContext : DbContext
{
    public BookManagementDbContext(DbContextOptions<BookManagementDbContext> options)
        : base(options)
    {
    }
    // DbSet properties for your entities
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Member> Members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure entity relationships and constraints
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(b => b.Id);
            entity.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(200);

            // Relationships
            entity.HasOne(b => b.Author)
                  .WithMany(a => a.Books)
                  .HasForeignKey(b => b.AuthorId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(b => b.Category)
                  .WithMany(c => c.Books)
                  .HasForeignKey(b => b.CategoryId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        // Additional entity configurations
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(100);
            entity.Property(m => m.Email)
            .IsRequired()
            .HasMaxLength(100);
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.FullName)
            .IsRequired()
            .HasMaxLength(100);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);
        });
    }
}


