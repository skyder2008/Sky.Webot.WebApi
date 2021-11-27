using Volo.Abp.Modularity;

namespace Sky.Webot
{
    [DependsOn(
        typeof(WebotApplicationModule),
        typeof(WebotDomainTestModule)
        )]
    public class WebotApplicationTestModule : AbpModule
    {

    }
}