using System;
using System.Configuration;
using System.Web.Mvc;

namespace SOC.Web.Admin.Helpers
{
    public static class UrlHelperExtension
    {
        public static string StaticContent(this UrlHelper helper, string resource)
        {
            var cdnUrl = ConfigurationManager.AppSettings["CDNURL"];
            return helper.Content(string.Format("{0}/{1}", cdnUrl, resource));
        }

        public static string ExternalContent(this UrlHelper helper, string resource)
        {
            var extUrl = ConfigurationManager.AppSettings["ExternalContentUrl"];
            return helper.Content(string.Format("{0}/{1}", extUrl, resource));
        }

    }
}