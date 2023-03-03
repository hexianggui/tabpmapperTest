using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Motest.TEST.EntityFrameworkCore;

[ConnectionStringName(TESTDbProperties.ConnectionStringName)]
public interface ITESTDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
