using Microsoft.EntityFrameworkCore;
using TestStreamRender.Models;

namespace TestStreamRender;

public class TestDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<TestModelOk> OkModels { get; set; }
    public DbSet<TestModelKo> KoModels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TestModelOk>()
            .HasData(GenerateTestData<TestModelOk>());

        modelBuilder.Entity<TestModelKo>()
            .HasData(GenerateTestData<TestModelKo>());
    }

    private IEnumerable<T> GenerateTestData<T>() where T : BaseModel, new()
    {
        for (int i = 0; i < 10000; i++)
        {
            yield return new T() { Id = Guid.NewGuid(), Test = $"TEST{i}" };
        }
    }
}
