using VinylShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// AddControllersWithViews - allows to register both the controller classes and the corresponding Razor views
// in the MVC middleware pipeline
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<VinylShopDbContext>(
           options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VinylShop;Trusted_Connection=True;User Id=vladm;Password="));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IVinylRepository, VinylRepository>();

var app = builder.Build();

// static files usage
app.UseStaticFiles();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();

