using Microsoft.AspNetCore.Http;

namespace CleanArchitectureDotnet.Presentation.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }catch(Exception ex)
            {
                //TODO:
            }
        }
    }
}

