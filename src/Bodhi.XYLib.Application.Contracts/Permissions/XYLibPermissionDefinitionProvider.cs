using Bodhi.XYLib.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Bodhi.XYLib.Permissions
{
    public class XYLibPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(XYLibPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(XYLibPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<XYLibResource>(name);
        }
    }
}
