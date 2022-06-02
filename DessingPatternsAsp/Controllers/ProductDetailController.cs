using DessingPatternsAsp.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Tools;
using Tools.Earnings;

namespace DessingPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly IOptions<MyConfig> _config;
        private LocalEarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory,
                                       ForeignEarnFactory foreignEarnFactory,
                                       IOptions<MyConfig> config)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
            _config = config;
        }

        public IActionResult Index(decimal total)
        {
            Log.GetInstance(_config.Value.PathLog).Info("Entro a ProductDetail");

            //PRODUCTS
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //TOTAL
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
