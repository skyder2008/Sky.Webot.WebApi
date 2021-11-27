using Sky.Webot.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Sky.Webot
{
    [DependsOn(
        typeof(WebotEntityFrameworkCoreTestModule)
        )]
    public class WebotDomainTestModule : AbpModule
    {

    }
}