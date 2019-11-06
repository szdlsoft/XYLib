using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Bodhi.XYLib.EntityFrameworkCore
{
    [DependsOn(
        typeof(XYLibEntityFrameworkCoreModule)
        )]
    public class XYLibEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<XYLibMigrationsDbContext>();
        }
    }
}
