using Bodhi.XYLib.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Bodhi.XYLib
{
    [DependsOn(
        typeof(XYLibEntityFrameworkCoreTestModule)
        )]
    public class XYLibDomainTestModule : AbpModule
    {

    }
}