using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace CARD10.UniversalReadingList.Web.Helpers
{
    public static class NavigationHelper
    {
        public static MvcHtmlString HomeUrl(this HtmlHelper htmlHelper)
        {
            return htmlHelper.ActionLink("Home", "Index", "Home");
        }

        public static MvcHtmlString HomeUrl(this HtmlHelper htmlHelper, object routeValues, object htmlAttributes)
        {
            return htmlHelper.ActionLink("Home", "Index", routeValues: routeValues, htmlAttributes: htmlAttributes);
        }
    }
}