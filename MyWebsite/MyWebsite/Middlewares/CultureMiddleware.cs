using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Localization.Routing;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MyWebsite.Middlewares
{
    public class CultureMiddleware
    {
        private static readonly List<CultureInfo> _supportedCultures = new List<CultureInfo>
        {
            new CultureInfo("en-GB"),
            new CultureInfo("zh-TW")
        };

        private static readonly RequestLocalizationOptions _localizationOptions = new RequestLocalizationOptions()
        {
            DefaultRequestCulture = new RequestCulture(_supportedCultures.First()),
            SupportedCultures = _supportedCultures,
            SupportedUICultures = _supportedCultures,
            RequestCultureProviders = new[]
            {
                new RouteDataRequestCultureProvider() { Options = _localizationOptions }
            }
        };

        public void Configure(IApplicationBuilder app)
        {
            app.UseRequestLocalization(_localizationOptions);
        }
    }
}