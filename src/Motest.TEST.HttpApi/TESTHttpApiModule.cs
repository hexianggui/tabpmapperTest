using Localization.Resources.AbpUi;
using Motest.TEST.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Motest.TEST;

[DependsOn(
    typeof(TESTApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class TESTHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TESTHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<TESTResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
