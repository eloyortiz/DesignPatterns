using Microsoft.AspNetCore.Mvc;
using Tools.Earnings;

namespace DessingPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            //FACTORIES
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);

            //PRODUCTS
            var localEarn = localEarnFactory.GetEarn();

            //TOTAL
            ViewBag.totalLocal = total + localEarn.Earn(total);

            return View();
        }
    }
}
