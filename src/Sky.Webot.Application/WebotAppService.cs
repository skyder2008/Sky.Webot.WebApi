using System;
using System.Collections.Generic;
using System.Text;
using Sky.Webot.Localization;
using Volo.Abp.Application.Services;

namespace Sky.Webot
{
    /* Inherit your application services from this class.
     */
    public abstract class WebotAppService : ApplicationService
    {
        protected WebotAppService()
        {
            LocalizationResource = typeof(WebotResource);
        }
    }
}
