using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Motest.TEST.EntityFrameworkCore;

public class TESTHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<TESTHttpApiHostMigrationsDbContext>
{
    public TESTHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TESTHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new TESTHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
