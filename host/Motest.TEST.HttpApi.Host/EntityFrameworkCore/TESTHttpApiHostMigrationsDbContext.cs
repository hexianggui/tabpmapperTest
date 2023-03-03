using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Motest.TEST.EntityFrameworkCore;

public class TESTHttpApiHostMigrationsDbContext : AbpDbContext<TESTHttpApiHostMigrationsDbContext>
{
    public TESTHttpApiHostMigrationsDbContext(DbContextOptions<TESTHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureTEST();
    }
}
