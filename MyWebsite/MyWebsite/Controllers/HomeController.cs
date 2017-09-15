using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MyWebsite.Middlewares;
using MyWebsite.Models;

namespace MyWebsite.Controllers
{
    [MiddlewareFilter(typeof(CultureMiddleware))]
    public class HomeController : Controller
    {
        private readonly IStringLocalizer _localizer;
        private readonly IStringLocalizer _sharedLocalizer;

        public HomeController(IStringLocalizer<HomeController> localizer,
            IStringLocalizer<SharedResource> sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }

        public IActionResult Index()
        {
            return View(model: new SampleModel());
        }

        public string Content()
        {
            return $"CurrentCulture: {CultureInfo.CurrentCulture.Name}\r\n"
                 + $"CurrentUICulture: {CultureInfo.CurrentUICulture.Name}\r\n"
                 + $"Resources\\Controllers\\HomeController: {_localizer["Hello"]}\r\n"
                 + $"Resources\\SharedResource: {_sharedLocalizer["Hello"]}";
        }
    }
}