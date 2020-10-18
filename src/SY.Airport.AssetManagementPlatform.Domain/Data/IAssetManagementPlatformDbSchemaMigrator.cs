using System.Threading.Tasks;

namespace SY.Airport.AssetManagementPlatform.Data
{
    public interface IAssetManagementPlatformDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
