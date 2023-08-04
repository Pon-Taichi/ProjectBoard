using ProjectBoardApi;
using ProjectBoardApi.Domain.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseReDoc();
}
app.UseHttpsRedirection();

app.MapGroup("/projects").MapProjectHandler().WithTags("Projects");

app.Run();