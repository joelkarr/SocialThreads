using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOC.WEB.Controllers
{
    public partial class ManageController : Controller
    {
        //
        // GET: /Manage/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
