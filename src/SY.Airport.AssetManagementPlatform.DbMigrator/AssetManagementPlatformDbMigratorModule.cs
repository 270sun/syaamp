using SY.Airport.AssetManagementPlatform.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SY.Airport.AssetManagementPlatform.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AssetManagementPlatformEntityFrameworkCoreDbMigrationsModule),
        typeof(AssetManagementPlatformApplicationContractsModule)
        )]
    public class AssetManagementPlatformDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
