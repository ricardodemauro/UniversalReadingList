using CARD10.UniversalReadingList.Web.Models;
using CARD10.UniversalReadingList.Web.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using CARD10.UniversalReadingList.Web.Helpers;

namespace CARD10.UniversalReadingList.Web.Controllers
{
    public class AccountController : ApiController
    {
        private UserManager<ApplicationUser> userManager;

        public UserManager<ApplicationUser> UserManager
        {
            get { return userManager ?? this.GetApplicationUser(); }
            set { userManager = value; }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> Register(RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await UserManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
