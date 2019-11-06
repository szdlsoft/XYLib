using System.Threading.Tasks;

namespace Bodhi.XYLib.Data
{
    public interface IXYLibDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
