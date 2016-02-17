using CARD10.UniversalReadingList.Web.Models;
using CARD10.UniversalReadingList.Web.Provider;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity.Owin;

namespace CARD10.UniversalReadingList.Web.Helpers
{
    public static class ApiControllerExtensions
    {
        public static UserManager<ApplicationUser> GetApplicationUser(this ApiController controller)
        {
            return HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
    }
}
