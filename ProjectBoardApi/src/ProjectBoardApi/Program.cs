var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.MapGet("/", () => "Hello World!");

app.MapGet("/projects", () =>
{
  return TypedResults.Ok(
    new List<Project>
    {
      new Project("1", "sample"),
      new Project("2", "sample2")
    });
}).WithTags("Projects");

app.Run();

record Project(string id, string name);

