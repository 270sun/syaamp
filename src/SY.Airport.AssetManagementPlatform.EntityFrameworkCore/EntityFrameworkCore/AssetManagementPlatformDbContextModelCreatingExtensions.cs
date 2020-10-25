using Microsoft.EntityFrameworkCore;
using SY.Airport.AssetManagementPlatform.Books;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

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

            builder.Entity<Book>(b =>
            {
                b.ToTable(AssetManagementPlatformConsts.DbTablePrefix + "Books", AssetManagementPlatformConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}