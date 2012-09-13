using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SOC.WEB.MVC.Models.Base;
using SOC.Web.Models.ViewModels.Base;

namespace SOC.WEB.MVC.Controllers
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
            if (model.Shop == "www" || model.Shop == "socialthreads")
            {
                return View("ComingSoon", model);
            }
            return RedirectToAction("Search", "Order");
        }

        public virtual ActionResult Test()
        {
            return View();
        }
    }
}
