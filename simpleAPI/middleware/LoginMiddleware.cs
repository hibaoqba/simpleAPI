namespace simpleAPI.middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var logger = httpContext.RequestServices.GetRequiredService<ILogger<LoggingMiddleware>>();
            logger.LogInformation($"Request Method: {httpContext.Request.Method} - Request Path: {httpContext.Request.Path}");
            await _next(httpContext);
        }
    }

}
