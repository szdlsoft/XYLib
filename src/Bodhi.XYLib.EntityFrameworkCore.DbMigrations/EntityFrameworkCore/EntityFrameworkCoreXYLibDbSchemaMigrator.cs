using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bodhi.XYLib.Data;
using Volo.Abp.DependencyInjection;

namespace Bodhi.XYLib.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreXYLibDbSchemaMigrator 
        : IXYLibDbSchemaMigrator, ITransientDependency
    {
        private readonly XYLibMigrationsDbContext _dbContext;

        public EntityFrameworkCoreXYLibDbSchemaMigrator(XYLibMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}