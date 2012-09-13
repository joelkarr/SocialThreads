// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace SOC.Web.Controllers {
    public partial class OrderController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public OrderController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected OrderController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Form() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Form);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public OrderController Actions { get { return MVC.Order; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Order";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Order";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Form = "Form";
            public readonly string GetDefault = "GetDefault";
            public readonly string Search = "Search";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string Form = "Form";
            public const string GetDefault = "GetDefault";
            public const string Search = "Search";
        }


        static readonly ActionParamsClass_Form s_params_Form = new ActionParamsClass_Form();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Form FormParams { get { return s_params_Form; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Form {
            public readonly string id = "id";
        }
        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Form = "~/Views/Order/Form.cshtml";
            public readonly string Search = "~/Views/Order/Search.cshtml";
            static readonly _Partial s_Partial = new _Partial();
            public _Partial Partial { get { return s_Partial; } }
            public partial class _Partial{
                public readonly string Product = "~/Views/Order/Partial/Product.cshtml";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_OrderController: SOC.Web.Controllers.OrderController {
        public T4MVC_OrderController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Form(string id) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Form);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult GetDefault() {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.GetDefault);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Search() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Search);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591