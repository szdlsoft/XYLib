using System;
using System.Collections.Generic;
using System.Text;
using Bodhi.XYLib.Localization;
using Volo.Abp.Application.Services;

namespace Bodhi.XYLib
{
    /* Inherit your application services from this class.
     */
    public abstract class XYLibAppService : ApplicationService
    {
        protected XYLibAppService()
        {
            LocalizationResource = typeof(XYLibResource);
        }
    }
}
