using System.Web.Mvc;

namespace SOC.WEB.MVC.Controllers
{
    public partial class StoreController : Controller
    {
        //
        // GET: /Store/

        public virtual ActionResult OrderForm()
        {
            return View();
        }

    }
}
