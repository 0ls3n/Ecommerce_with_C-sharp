using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Ecommerce_Project.Data;
using Ecommerce_Project.Areas.Identity.Data;
using Ecommerce_Project.Models.Persistence;
using Ecommerce_Project.Models.Domain_Classes;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AuthDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AuthDbContextConnection' not found.");
var productDbConnectionString = builder.Configuration.GetConnectionString("ProductDbContextConenction") ?? throw new InvalidOperationException("Connection string 'ProductDbContextConenction' not found");

builder.Services.AddDbContext<AuthDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ProductDbContext>(options=> options.UseSqlServer(productDbConnectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<AuthDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IRepository<Product>, Repository<Product>>(); // Added the Repository as a service

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();