using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SY.Airport.AssetManagementPlatform.Data;
using Volo.Abp.DependencyInjection;

namespace SY.Airport.AssetManagementPlatform.EntityFrameworkCore
{
    public class EntityFrameworkCoreAssetManagementPlatformDbSchemaMigrator
        : IAssetManagementPlatformDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAssetManagementPlatformDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AssetManagementPlatformMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AssetManagementPlatformMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}