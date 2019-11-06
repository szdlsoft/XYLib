using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Bodhi.XYLib.Web
{
    [Dependency(ReplaceServices = true)]
    public class XYLibBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "XYLib";
    }
}
