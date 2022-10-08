using System;
using System.Diagnostics;

namespace Rookies5MiddleWare.Middleware
{
    public class LogginMiddleware
    {
        private readonly RequestDelegate _next;
        public LogginMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            string requestInformation = "scheme:" + request.Scheme +
            "\t Host" + request.Host +
            "\t Path" + request.Path +
            "\t QuerryString: " + request.QueryString +
            "\t RequestBody" + request.Body;

            Debug.Write(requestInformation);
            File.WriteAllText("textInformation", requestInformation);

            await _next(context);
        }
    }
}