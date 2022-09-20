using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using TranscationApp.Data;
using TranscationApp.Interfaces;
using TranscationApp.Models;
using TranscationApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<TranscationContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString
("DbConnection")));
builder.Services.AddScoped<ICreditServices, CreditServices>();
builder.Services.AddScoped<IDebitServices, DebitServices>();
builder.Services.AddScoped<ITranscationList, TranscationList>();
builder.Services.AddScoped<ITranscationServices, TranscationServices>();
builder.Services.AddBlazorStrap();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
