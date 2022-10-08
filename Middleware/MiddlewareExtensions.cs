using System;
using Microsoft.AspNetCore.Builder;

namespace Rookies5MiddleWare.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogginMiddleware>();
        }
    }
}