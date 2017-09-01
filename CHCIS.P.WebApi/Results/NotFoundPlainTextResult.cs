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
    public class NotFoundPlainTextResult : IHttpActionResult
    {
        public HttpRequestMessage _request;
        public string _message;

        public NotFoundPlainTextResult(HttpRequestMessage request, string message)
        {
            _request = request;
            _message = message;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage();

            if (!string.IsNullOrWhiteSpace(_message))
            {
                //response.Content = new StringContent(Message);
                response = _request.CreateErrorResponse(HttpStatusCode.NotFound, new Exception(_message));
            }

            response.RequestMessage = _request;

            return Task.FromResult(response);
        }
    }
}