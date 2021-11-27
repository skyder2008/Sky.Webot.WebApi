using Sky.Webot.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Sky.Webot.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WebotEntityFrameworkCoreModule),
        typeof(WebotApplicationContractsModule)
        )]
    public class WebotDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
