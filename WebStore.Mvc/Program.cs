using WebStore.Mvc.Servises.Interfaces;
using WebStore.Mvc.Servises.InMemory;
using WebStore.Mvc.Models;
using WebStore.Mvc.DataAccessLayer;
using WebStore.Mvc.Routes;

var builder = WebApplication.CreateBuilder(args);

var servisesRef = builder.Services;
servisesRef.AddControllersWithViews();
servisesRef.AddSingleton<IRepository<EmployeViewModel>, EmployeRepository>();
servisesRef.AddTransient<IProductData, ProductRepository>();

servisesRef.AddPersistence(builder.Configuration);
servisesRef.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    var context = serviceProvider.GetService<WebStoreDbContext>();

    DbInitializer.Initialize(context);
}

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHomeRoutes();
    endpoints.MapDefaultControllerRoute();
});

app.Run();