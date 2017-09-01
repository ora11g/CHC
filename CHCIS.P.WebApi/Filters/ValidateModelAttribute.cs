using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace CHCIS.P.WebApi.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var request = actionContext.Request;
                        
            if (actionContext.ActionArguments.Any(kv => kv.Value == null))
            {
                actionContext.Response = request.CreateErrorResponse(HttpStatusCode.BadRequest, "Argument cannot be null.");
            }

            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = request.CreateErrorResponse(HttpStatusCode.BadRequest, actionContext.ModelState);
            }            
        }
    }
}