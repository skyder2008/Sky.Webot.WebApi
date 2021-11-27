using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Sky.Webot.Data
{
    /* This is used if database provider does't define
     * IWebotDbSchemaMigrator implementation.
     */
    public class NullWebotDbSchemaMigrator : IWebotDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}