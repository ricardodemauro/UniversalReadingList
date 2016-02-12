using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using CARD10.UniversalReadingList.Web.Models;
using Microsoft.Owin.Security.OAuth;
using CARD10.UniversalReadingList.Web.Provider;

[assembly: OwinStartup(typeof(CARD10.UniversalReadingList.Web.Startup))]

namespace CARD10.UniversalReadingList.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigureAuth(app);
        }

        public static void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);

            // Configure the application for OAuth based flow
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                //For Dev enviroment only (on production should be AllowInsecureHttp = false)
#if DEBUG
                AllowInsecureHttp = true,
#endif
                TokenEndpointPath = new PathString("/oauth2/token"),
                //set the token expiration time
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(400),
                Provider = new AppOAuthProvider(),
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthServerOptions);
        }
    }
}
