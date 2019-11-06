using Volo.Abp.Settings;

namespace Bodhi.XYLib.Settings
{
    public class XYLibSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(XYLibSettings.MySetting1));
        }
    }
}
