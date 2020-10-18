using Volo.Abp.Modularity;

namespace SY.Airport.AssetManagementPlatform
{
    [DependsOn(
        typeof(AssetManagementPlatformApplicationModule),
        typeof(AssetManagementPlatformDomainTestModule)
        )]
    public class AssetManagementPlatformApplicationTestModule : AbpModule
    {

    }
}