using Bodhi.XYLib.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bodhi.XYLib.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class XYLibController : AbpController
    {
        protected XYLibController()
        {
            LocalizationResource = typeof(XYLibResource);
        }
    }
}