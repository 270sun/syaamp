using System;
using System.Collections.Generic;
using System.Text;
using SY.Airport.AssetManagementPlatform.Localization;
using Volo.Abp.Application.Services;

namespace SY.Airport.AssetManagementPlatform
{
    /* Inherit your application services from this class.
     */
    public abstract class AssetManagementPlatformAppService : ApplicationService
    {
        protected AssetManagementPlatformAppService()
        {
            LocalizationResource = typeof(AssetManagementPlatformResource);
        }
    }
}
