using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using CHCIS.P.WebApi.Filters;
using CHCIS.P.WebApi.Results;
using System.Globalization;

namespace CHCIS.P.WebApi.Controllers
{
    public class BaseApiController : ApiController        
    {
        protected virtual string GetErrorMessage(Exception ex)
        {
            ex = ex.Unwrap();

            StringBuilder strBuilder = new StringBuilder();

            if (ex is DbEntityValidationException)
            {
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
            }

            return strBuilder.ToString();
        }

        //protected T ReadContentAs<T>()
        //{
        //    if (Request.Content != null)
        //    {
        //        try
        //        {
        //            if (Request.Content.IsXmlContent())
        //            {
        //                return SerializationHelper.DeserializeXml<T>(Request.Content.ReadAsStreamAsync().Result);
        //            }

        //            if (Request.Content.IsJsonContent())
        //            {
        //                return SerializationHelper.DeserializeJson<T>(Request.Content.ReadAsStreamAsync().Result);
        //            }
        //        }
        //        catch
        //        {
        //            return default(T);
        //        }
        //    }

        //    return default(T);
        //}

        //protected internal IHttpActionResult Forbidden()
        //{
        //    return new ForbiddenResult(Request);
        //}

        //protected internal IHttpActionResult Forbidden(string reason)
        //{
        //    return new ForbiddenResult(Request, reason);
        //}        

        //protected internal IHttpActionResult AcceptedContent(string location)
        //{
        //    return new AcceptedContentResult(Request, location);
        //}

        //protected virtual internal IHttpActionResult NoContent()
        //{
        //    return new NoContentResult(Request);
        //}

        //protected internal IHttpActionResult NotFoundPlainText(string message)
        //{
        //    return new NotFoundPlainTextResult(Request, message);
        //}
        //protected internal string GetLowerCase(Type type)
        //{
        //    return type.Name.ToLower().Replace("dto", string.Empty);
        //}

        //protected internal string GetTitleCase(Type type)
        //{
        //    string name = type.Name.ToLower().Replace("dto", string.Empty);
        //    TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;

        //    return textInfo.ToTitleCase(name);
        //}
    }
}
