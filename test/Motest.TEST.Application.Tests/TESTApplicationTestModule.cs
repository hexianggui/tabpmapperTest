using Volo.Abp.Modularity;

namespace Motest.TEST;

[DependsOn(
    typeof(TESTApplicationModule),
    typeof(TESTDomainTestModule)
    )]
public class TESTApplicationTestModule : AbpModule
{

}
