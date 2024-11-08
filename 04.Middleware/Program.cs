using _04.Middleware.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseMiddleware<ResponseEditingMiddleware>();
app.UseMiddleware<RequestEditingMiddleware>(); //Olu�turmu� oldu�umuz middleware'yi bu �ekilde �a��rd�k.

app.Run();
