using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sky.Webot.Data;
using Volo.Abp.DependencyInjection;

namespace Sky.Webot.EntityFrameworkCore
{
    public class EntityFrameworkCoreWebotDbSchemaMigrator
        : IWebotDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreWebotDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the WebotDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<WebotDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
