using Bodhi.XYLib.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Bodhi.XYLib.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(XYLibEntityFrameworkCoreDbMigrationsModule),
        typeof(XYLibApplicationContractsModule)
        )]
    public class XYLibDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
