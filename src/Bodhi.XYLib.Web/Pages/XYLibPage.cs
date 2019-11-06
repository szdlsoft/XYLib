using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Bodhi.XYLib.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Bodhi.XYLib.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Bodhi.XYLib.Web.Pages.XYLibPage
     */
    public abstract class XYLibPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<XYLibResource> L { get; set; }
    }
}
