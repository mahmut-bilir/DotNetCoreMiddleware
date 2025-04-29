public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next=next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
    Console.Writeline($"[Middleware] Request: {context.Request.Method} {context.Request.Path}");
    
    //Go to next middleware.
    await _next(context);
    }

}