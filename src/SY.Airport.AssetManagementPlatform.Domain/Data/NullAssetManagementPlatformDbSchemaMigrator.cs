using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SY.Airport.AssetManagementPlatform.Data
{
    /* This is used if database provider does't define
     * IAssetManagementPlatformDbSchemaMigrator implementation.
     */
    public class NullAssetManagementPlatformDbSchemaMigrator : IAssetManagementPlatformDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}