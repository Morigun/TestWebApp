var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run(async (context) =>
{
    var response = context.Response;
    var request = context.Request;
});

app.Run();
