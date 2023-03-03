using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Motest.TEST;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(TESTDomainSharedModule)
)]
public class TESTDomainModule : AbpModule
{

}
