using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Motest.TEST.EntityFrameworkCore;

[ConnectionStringName(TESTDbProperties.ConnectionStringName)]
public class TESTDbContext : AbpDbContext<TESTDbContext>, ITESTDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<MapperTest> MbTests { get; set; }
    public TESTDbContext(DbContextOptions<TESTDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTEST();
       
    }
}
