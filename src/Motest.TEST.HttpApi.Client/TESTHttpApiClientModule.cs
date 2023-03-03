using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Motest.TEST;

[DependsOn(
    typeof(TESTApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class TESTHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TESTApplicationContractsModule).Assembly,
            TESTRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TESTHttpApiClientModule>();
        });

    }
}
