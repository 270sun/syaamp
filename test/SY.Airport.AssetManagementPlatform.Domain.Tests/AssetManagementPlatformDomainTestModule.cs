using SY.Airport.AssetManagementPlatform.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SY.Airport.AssetManagementPlatform
{
    [DependsOn(
        typeof(AssetManagementPlatformEntityFrameworkCoreTestModule)
        )]
    public class AssetManagementPlatformDomainTestModule : AbpModule
    {

    }
}