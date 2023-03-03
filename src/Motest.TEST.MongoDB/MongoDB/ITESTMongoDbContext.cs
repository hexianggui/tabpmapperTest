using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Motest.TEST.MongoDB;

[ConnectionStringName(TESTDbProperties.ConnectionStringName)]
public interface ITESTMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
