global using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICounter, NamedCounter>();
builder.Services.AddControllersWithViews();             //enable MVC
var app = builder.Build();
//for each Controller derived XController class, map
//its public method Y to path /X/Y/{id} with X = Home
//and Y = Index by default 
app.MapDefaultControllerRoute();
app.Run();
