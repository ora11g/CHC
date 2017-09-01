using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace CHCIS.P.WebApi.Providers
{
    public class SimpleRefreshTokenProvider : OAuthAuthorizationServerProvider
    {
        public override async Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            var originalClient = context.Ticket.Properties.Dictionary["as:client_id"];
            var currentClient = context.ClientId;

            if (originalClient != currentClient)
            {
                context.Rejected();
                return;
            }

            var newId = new ClaimsIdentity(context.Ticket.Identity);
            newId.AddClaim(new Claim("newClaim", "refreshToken"));

            var newTicket = new AuthenticationTicket(newId, context.Ticket.Properties);
            context.Validated(newTicket);

            await base.GrantRefreshToken(context);
        }

        public override Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        {
            var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);

            var props = new AuthenticationProperties(new Dictionary<string, string>
                    {
                        { "as:client_id", context.ClientId }
                    });
            var ticket = new AuthenticationTicket(oAuthIdentity, props);
            return base.GrantClientCredentials(context);
        }

        //public override async Task GrantClientCredentials(OAuthGrantClientCredentialsContext context)
        //{
        //    var oAuthIdentity = new ClaimsIdentity(context.Options.AuthenticationType);

        //    var props = new AuthenticationProperties(new Dictionary<string, string>
        //        {
        //            { "as:client_id", context.ClientId }
        //        });
        //    var ticket = new AuthenticationTicket(oAuthIdentity, props);

        //    context.Validated(ticket);
        //}
    }
}