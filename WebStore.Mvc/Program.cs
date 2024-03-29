using WebStore.Mvc.Servises.Interfaces;
using WebStore.Mvc.Servises.Sql;
using WebStore.Mvc.Servises.InMemory;
using WebStore.Mvc.Models;
using WebStore.Mvc.DataAccessLayer;
using WebStore.Mvc.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WebStore.Mvc.Constants;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
var servisesRef = builder.Services;

servisesRef.AddControllersWithViews();
servisesRef.AddSingleton<IRepository<EmployeViewModel>, EmployeRepository>();
servisesRef.AddScoped<IProductData, ProductRepository>();

servisesRef.AddPersistence(builder.Configuration);
servisesRef.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

servisesRef.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<WebStoreDbContext>()
    .AddDefaultTokenProviders();

servisesRef.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 4;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 10;
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;
});

servisesRef.ConfigureApplicationCookie(options => { 
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(150);
    options.LoginPath = "/account/login";
    options.LogoutPath = "/account/logout";
    options.AccessDeniedPath = "/account/accessDenied";

    options.SlidingExpiration = true;
});

servisesRef.AddControllersWithViews(options =>
{
    options.EnableEndpointRouting = false;
});

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var context = serviceProvider.GetService<WebStoreDbContext>();
    var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

    if ( context != null)
    {
        try
        {
            DbInitializer.Initialize(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Initialize db error");
        }
    } 
    else
    {
        logger.LogError(String.Empty, "WebStoreDbContext is null");
    }
}

app.UseStaticFiles();

app.UseAuthentication();

app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();