using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;
using System.Reflection;
using System.Text;
using log4net;

namespace CHCIS.P.WebApi.Filters
{
    public static class ExceptionExtensions
    {
        public static Exception Unwrap1(this Exception ex)
        {
            while (true)
            {
                //var tiex = ex as TargetInvocationException;
                //if (tiex == null)
                //    return ex;

                //ex = tiex.InnerException;               

                ex = ex.InnerException;
                if (ex.InnerException == null)
                {
                    return ex;
                }
            }            
        }
    }

    public class ControllerExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var ex = actionExecutedContext.Exception.Unwrap1();
            
            var response = new HttpResponseMessage();
            
            if (ex is DbEntityValidationException)
            {
                StringBuilder strBuilder = new StringBuilder();
       
                strBuilder.AppendFormat("{0} Exception: ", typeof(DbEntityValidationException).Name);
                strBuilder.AppendLine();
                var validationException = ex as DbEntityValidationException;
                if (validationException.EntityValidationErrors.Any())
                {
                    var entityValidationError = validationException.EntityValidationErrors.First();
                    foreach (var validationError in entityValidationError.ValidationErrors)
                    {
                        strBuilder.AppendFormat("{0}: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        strBuilder.AppendLine();
                    }
                }

                string errorMessage = strBuilder.ToString();
                response.Content = new StringContent(errorMessage);
                response.StatusCode = HttpStatusCode.Conflict;
                actionExecutedContext.Response = response;

                Log.ErrorFormat("{0}--- Stack Information: {1}", errorMessage, ex.StackTrace);

                return;
            }
            else if (ex is NotImplementedException)
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
           
            response.Content = new StringContent(ex.Message);

            actionExecutedContext.Response = response;
            Log.ErrorFormat("{0}--- Stack Information: {1}", ex.Message, ex.StackTrace);
        }
    }
}