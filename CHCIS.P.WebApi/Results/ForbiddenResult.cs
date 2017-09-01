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
    public class ForbiddenResult : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly string _reason;

        public ForbiddenResult(HttpRequestMessage request)
            : this(request, "Forbidden")
        {
        }

        public ForbiddenResult(HttpRequestMessage request, string reason)
        {
            _request = request;
            _reason = reason;
        }        

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(HttpStatusCode.Forbidden, _reason);
            return Task.FromResult(response);
        }
    }
}