using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Motest.TEST;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TESTHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class TESTConsoleApiClientModule : AbpModule
{

}
