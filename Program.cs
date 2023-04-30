using VinylShop.Models;

var builder = WebApplication.CreateBuilder(args);

// AddControllersWithViews - allows to register both the controller classes and the corresponding Razor views
// in the MVC middleware pipeline
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IVinylRepository, MockVinylRepository>();

var app = builder.Build();

// static files usage
app.UseStaticFiles();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();

