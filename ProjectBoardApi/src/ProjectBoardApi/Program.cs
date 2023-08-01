var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();