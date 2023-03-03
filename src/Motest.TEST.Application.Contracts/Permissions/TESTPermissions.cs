using Volo.Abp.Reflection;

namespace Motest.TEST.Permissions;

public class TESTPermissions
{
    public const string GroupName = "TEST";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(TESTPermissions));
    }
}
