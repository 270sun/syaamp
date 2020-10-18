using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace SY.Airport.AssetManagementPlatform.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AssetManagementPlatformHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AssetManagementPlatformConsoleApiClientModule : AbpModule
    {
        
    }
}
