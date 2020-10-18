using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SY.Airport.AssetManagementPlatform.EntityFrameworkCore
{
    [DependsOn(
        typeof(AssetManagementPlatformEntityFrameworkCoreModule)
        )]
    public class AssetManagementPlatformEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AssetManagementPlatformMigrationsDbContext>();
        }
    }
}
