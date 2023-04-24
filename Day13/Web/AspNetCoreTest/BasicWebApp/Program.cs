var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.UseStaticFiles();
app.UseMiddleware<BasicWebApp.MiddleWares.Pausing>(5);
app.MapGet("/Welcome", DoGreeting);
app.Run(); //app.Run("http://localhost:5001");

async Task DoGreeting(HttpResponse response, string guest = "Visitor")
{
    await response.WriteAsync(
        $"""
        <html>
            <head>
                <title>BasicWebApp</title>
            </head>
            <body>
                <h1> Welcome {guest}</h1>
                <b> Current Time :  </b> {DateTime.Now}
            </body>
        </html>
        """
    );
}
