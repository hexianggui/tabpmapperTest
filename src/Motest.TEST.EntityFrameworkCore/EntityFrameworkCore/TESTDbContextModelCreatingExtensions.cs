using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Motest.TEST.EntityFrameworkCore;

public static class TESTDbContextModelCreatingExtensions
{
    public static void ConfigureTEST(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
        builder.Entity<MapperTest>(b =>
        {
            b.ToTable(TESTDbProperties.DbTablePrefix+ "MapperTest", TESTDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            //...
        });
        /* Configure all entities here. Example:
        
        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(TESTDbProperties.DbTablePrefix + "Questions", TESTDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
