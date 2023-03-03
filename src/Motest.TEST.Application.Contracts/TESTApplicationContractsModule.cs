using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Motest.TEST;

[DependsOn(
    typeof(TESTDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class TESTApplicationContractsModule : AbpModule
{

}
