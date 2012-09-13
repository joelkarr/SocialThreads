using System.Web.Mvc;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.Web.Controllers
{
    public partial class HomeController : BaseController
    {
        public virtual ActionResult Index()
        {
            return ComingSoon();
        }

        public virtual ActionResult ComingSoon()
        {
            var model = new BaseViewModel(ViewData.Model as BaseViewModel);
            if(model.Shop == "www")
            {
                return View("ComingSoon", model);
            }
           return RedirectToAction(OrderController.ActionNameConstants.Search, OrderController.NameConst);
        }

        public virtual ActionResult Test()
        {
            return View();
        }
    }

}
