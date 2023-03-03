using Motest.TEST.Localization;
using Volo.Abp.Application.Services;

namespace Motest.TEST;

public abstract class TESTAppService : ApplicationService
{
    protected TESTAppService()
    {
        LocalizationResource = typeof(TESTResource);
        ObjectMapperContext = typeof(TESTApplicationModule);
    }
}
