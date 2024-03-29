﻿using System.Web.Mvc;
using SOC.Web.Helpers;
using SOC.Web.Models.ViewModels.Base;
using SOC.Web.Models.ViewModels.Base.Partial;

namespace SOC.Web.MVC.Controllers
{
    public partial class BaseController : Controller
    {
       
        #region Ovverrides
        protected ViewResult BaseView(IView view, object model = null)
        {
            var viewModel = model ??  new BaseViewModel();
            return ThemeView(view, viewModel, SiteTheme.Base);
        }

        protected ViewResult BaseView(string viewName, object model = null)
        {
            var viewModel = model ?? new BaseViewModel();
            return ThemeView(viewName, viewModel, SiteTheme.Base);
        }

        protected ViewResult ThemeView(string viewName, object model = null, SiteTheme theme = SiteTheme.None)
        {
            var viewModel = model ?? new BaseViewModel();
            switch (theme)
            {
                case SiteTheme.None:
                    theme = GetTheme();
                    return View(string.Format("/Themes/{0}/Views/{1}/{2}.cshtml", theme, RouteData.Values["controller"], viewName), viewModel);
                default:
                    return View(string.Format("/BaseViews/{0}.cshtml", viewName), viewModel);
            }
        }

        protected ViewResult ThemeView(IView view, object model = null, SiteTheme theme = SiteTheme.None)
        {
            var viewModel = model ?? new BaseViewModel();
            switch (theme)
            {
                case SiteTheme.None:
                    theme = GetTheme();
                    return View(string.Format("/App_Themes/{0}/Views/{1}/{2}.cshtml", theme, RouteData.Values["controller"], view), viewModel);
                default:
                    return View(string.Format("/BaseViews/{0}.cshtml", view), viewModel);
            }
        }

        private SiteTheme GetTheme()
        {
            return SiteTheme.Classic;
        }
        #endregion

        #region Events
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var model = filterContext.Controller.ViewData.Model as BaseViewModel ?? new BaseViewModel();
            model.Shop = filterContext.RequestContext.HttpContext.Request.Url.DnsSafeHost.Split('.')[0];
            model.Cart = GetCartFromSession();

            filterContext.Controller.ViewData.Model = model;
            base.OnActionExecuting(filterContext);
        }

        private CartViewModel GetCartFromSession()
        {
            var cart = Session["cart"] as CartViewModel ?? new CartViewModel();
            return cart;
        }

        #endregion
    }
}
