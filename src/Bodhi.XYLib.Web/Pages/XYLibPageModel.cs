using Bodhi.XYLib.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Bodhi.XYLib.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class XYLibPageModel : AbpPageModel
    {
        protected XYLibPageModel()
        {
            LocalizationResourceType = typeof(XYLibResource);
        }
    }
}