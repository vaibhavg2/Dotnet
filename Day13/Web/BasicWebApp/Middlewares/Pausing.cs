namespace BasicWebApp.MiddleWares;

public class Pausing
{
    private RequestDelegate next;
    private DateTime recent;
    private TimeSpan delay;

    public Pausing(RequestDelegate next, int count)
    {
        this.next = next;
        delay = TimeSpan.FromSeconds(count);
    }

    public async Task Invoke(HttpContext context)
    {
        var current = DateTime.Now;
        if(current - recent > delay)
        {
            recent = current;
            await next.Invoke(context);
        }
        else
        {
            await context.Response.WriteAsync("Server busy, try after some time...");
        }
    }
}
