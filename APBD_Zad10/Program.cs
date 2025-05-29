using APBD_Zad10.Database;
using APBD_Zad10.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>( options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
    );

builder.Services.AddScoped<IPerceptionService, PerceptionService>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.MapControllers();
app.UseAuthentication();

app.Run();