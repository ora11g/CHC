using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CHCIS.P.WebApi.Results
{
    public class NoContentResult : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _message;

        public NoContentResult(HttpRequestMessage request)
            : this(request, "No Content")
        {            
        }

        public NoContentResult(HttpRequestMessage request, string message)
        {
            _request = request;
            _message = message;
        }        

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(HttpStatusCode.NoContent, _message);
            return Task.FromResult(response);
        }
    }
}