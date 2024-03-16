using Microsoft.EntityFrameworkCore;
using TestStreamRender.Models;

namespace TestStreamRender;

public class TestDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<TestModel> Models { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TestModel>()
            .HasData([
                new TestModel { Id = Guid.NewGuid(), Test = "TEST1" },
                new TestModel { Id = Guid.NewGuid(), Test = "TEST2" },
                new TestModel { Id = Guid.NewGuid(), Test = "TEST3" }
                ]);
    }
}
