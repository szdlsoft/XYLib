using Volo.Abp.Modularity;

namespace Bodhi.XYLib
{
    [DependsOn(
        typeof(XYLibApplicationModule),
        typeof(XYLibDomainTestModule)
        )]
    public class XYLibApplicationTestModule : AbpModule
    {

    }
}