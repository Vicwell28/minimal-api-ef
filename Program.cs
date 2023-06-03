using minimal_api_ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MinimalAPIEFContext>(cxt => cxt.UseInMemoryDatabase("TasksDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async ([FromServices] MinimalAPIEFContext dbcxt) =>
{
    dbcxt.Database.EnsureCreated();

    return Results.Ok("Base de datos en memoria: " + dbcxt.Database.IsInMemory());
});

app.Run();
