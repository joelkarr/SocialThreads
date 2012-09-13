using System.Web.Mvc;

namespace SOC.WEB.MVC.Controllers
{
    public partial class PricingController : Controller
    {
        //
        // GET: /Pricing/

        public virtual ActionResult Quote()
        {
            return View();
        }

    }
}
