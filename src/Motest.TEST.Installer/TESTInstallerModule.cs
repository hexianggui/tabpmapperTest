using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Motest.TEST;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class TESTInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TESTInstallerModule>();
        });
    }
}
