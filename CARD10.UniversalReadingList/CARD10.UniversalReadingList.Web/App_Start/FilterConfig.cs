using System.Web;
using System.Web.Mvc;

namespace CARD10.UniversalReadingList.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
