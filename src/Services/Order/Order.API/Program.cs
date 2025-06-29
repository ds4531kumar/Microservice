using Order.API;
using Order.Application;
using Order.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
