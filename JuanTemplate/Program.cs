using JuanTemplate.DataAccesLayer;
using JuanTemplate.Interfaces;
using JuanTemplate.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContex>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<ILayoutService, LayoutService>();

var app = builder.Build();

app.UseStaticFiles();   
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();
