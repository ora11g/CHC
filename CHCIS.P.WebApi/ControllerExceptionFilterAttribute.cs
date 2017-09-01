using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace CHCIS.P.WebApi
{
    public class ControllerExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {            
            var ex = actionExecutedContext.Exception;

            if (ex is NotImplementedException)
            {
                response.StatusCode = HttpStatusCode.NotImplemented;
            }
            else if (ex is TimeoutException)
            {
                response.StatusCode = HttpStatusCode.RequestTimeout;
            }
            else if (ex is KeyNotFoundException || ex is ArgumentOutOfRangeException)
            {
                response.StatusCode = HttpStatusCode.NotFound;
            }
            else if (ex is ArgumentException)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
            }
            else
            {
                response.StatusCode = HttpStatusCode.InternalServerError;
            }

            actionExecutedContext.Response = new HttpResponseMessage()
            {
                Content = new StringContent(ex.Message),
                ReasonPhrase = response.StatusCode.ToString()
            };
        }       
    }

}

