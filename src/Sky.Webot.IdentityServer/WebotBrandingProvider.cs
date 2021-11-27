using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Sky.Webot
{
    [Dependency(ReplaceServices = true)]
    public class WebotBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Webot";
    }
}
