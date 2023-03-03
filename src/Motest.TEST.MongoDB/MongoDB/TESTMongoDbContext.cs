using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Motest.TEST.MongoDB;

[ConnectionStringName(TESTDbProperties.ConnectionStringName)]
public class TESTMongoDbContext : AbpMongoDbContext, ITESTMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureTEST();
    }
}
