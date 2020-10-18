using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SY.Airport.AssetManagementPlatform.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AssetManagementPlatformMigrationsDbContextFactory : IDesignTimeDbContextFactory<AssetManagementPlatformMigrationsDbContext>
    {
        public AssetManagementPlatformMigrationsDbContext CreateDbContext(string[] args)
        {
            AssetManagementPlatformEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AssetManagementPlatformMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AssetManagementPlatformMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SY.Airport.AssetManagementPlatform.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
