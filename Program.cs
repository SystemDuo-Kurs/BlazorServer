using BlazorServer;
using BlazorServer.Data;
using BlazorServer.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddTransient<PrimerServis>();
builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddDbContext<Db>(opcije =>
    opcije.UseSqlServer(builder.Configuration.GetConnectionString("DB")));
builder.Services.AddTransient<TestList>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();