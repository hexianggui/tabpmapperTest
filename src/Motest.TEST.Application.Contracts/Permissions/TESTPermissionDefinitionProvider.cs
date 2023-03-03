using Motest.TEST.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Motest.TEST.Permissions;

public class TESTPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TESTPermissions.GroupName, L("Permission:TEST"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TESTResource>(name);
    }
}
