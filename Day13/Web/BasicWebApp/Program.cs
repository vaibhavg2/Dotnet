using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<ICounter, CommonCounter>();
builder.Services.AddTransient<ICounter, NamedCounter>();
var app = builder.Build();
app.UseStaticFiles();
app.UseMiddleware<BasicWebApp.MiddleWares.Pausing>(5);
app.MapGet("/Welcome", DoGreeting);
app.MapPost("/Count", DoCounting);
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
                <h1>Welcome {guest}</h1>
                <b>Current Time: </b>{DateTime.Now}
            </body>
        </html>
        """
    );
}

async Task DoCounting(HttpRequest request, HttpResponse response, ICounter ctr)
{
    string name = request.Form["guest"];
    if(name.Length == 0)
        response.Redirect("/formpost.html?noname=true");
    else
    {
        int n = ctr.CountNext(name);
        await response.WriteAsync(
            $"""
            <html>
                <head>
                    <title>BasicWebApp</title>
                </head>
                <body>
                    <h1>Hello {name}</h1>
                    <b>Number of Greetings: </b>{n}
                </body>
            </html>
            """
        );
    }
}
