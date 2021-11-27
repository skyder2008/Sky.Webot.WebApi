using Sky.Webot.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sky.Webot.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WebotController : AbpController
    {
        protected WebotController()
        {
            LocalizationResource = typeof(WebotResource);
        }
    }
}