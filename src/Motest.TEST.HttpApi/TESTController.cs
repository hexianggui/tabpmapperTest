using Motest.TEST.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Motest.TEST;

public abstract class TESTController : AbpControllerBase
{
    protected TESTController()
    {
        LocalizationResource = typeof(TESTResource);
    }
}
