using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Bodhi.XYLib.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(XYLibHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class XYLibConsoleApiClientModule : AbpModule
    {
        
    }
}
