using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SY.Airport.AssetManagementPlatform.EntityFrameworkCore
{
    public static class AssetManagementPlatformDbContextModelCreatingExtensions
    {
        public static void ConfigureAssetManagementPlatform(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AssetManagementPlatformConsts.DbTablePrefix + "YourEntities", AssetManagementPlatformConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}