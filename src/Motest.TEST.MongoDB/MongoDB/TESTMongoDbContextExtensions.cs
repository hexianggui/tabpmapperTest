using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Motest.TEST.MongoDB;

public static class TESTMongoDbContextExtensions
{
    public static void ConfigureTEST(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
