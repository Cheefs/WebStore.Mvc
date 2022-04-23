using WebStore.Mvc.Infrastructure.Interfaces;
using WebStore.Mvc.Infrastructure;
using WebStore.Mvc.Models;

var builder = WebApplication.CreateBuilder(args);

var servisesRef = builder.Services;
servisesRef.AddControllersWithViews();
servisesRef.AddRouting(config =>
{
    config.LowercaseUrls = true;
    config.LowercaseQueryStrings = true;
});
servisesRef.AddSingleton<IRepository<EmployeViewModel>, EmployeRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();