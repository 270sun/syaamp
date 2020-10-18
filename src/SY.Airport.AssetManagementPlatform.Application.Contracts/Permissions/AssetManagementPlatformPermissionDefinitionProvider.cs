using SY.Airport.AssetManagementPlatform.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SY.Airport.AssetManagementPlatform.Permissions
{
    public class AssetManagementPlatformPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AssetManagementPlatformPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AssetManagementPlatformPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AssetManagementPlatformResource>(name);
        }
    }
}
