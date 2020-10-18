using SY.Airport.AssetManagementPlatform.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SY.Airport.AssetManagementPlatform.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AssetManagementPlatformController : AbpController
    {
        protected AssetManagementPlatformController()
        {
            LocalizationResource = typeof(AssetManagementPlatformResource);
        }
    }
}