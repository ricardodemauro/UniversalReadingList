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
        public string PublicClientId { get; private set; }

        public OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            ConfigureAuth(app);
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationDbContext.Create);

            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                // Note: Remove the following line before you deploy to production:
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}
