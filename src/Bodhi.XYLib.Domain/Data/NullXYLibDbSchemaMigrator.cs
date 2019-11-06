using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Bodhi.XYLib.Data
{
    /* This is used if database provider does't define
     * IXYLibDbSchemaMigrator implementation.
     */
    public class NullXYLibDbSchemaMigrator : IXYLibDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}