using WebStore.Mvc.Infrastructure.Interfaces;
using WebStore.Mvc.Infrastructure.InMemory;
using WebStore.Mvc.Models;

var builder = WebApplication.CreateBuilder(args);

var servisesRef = builder.Services;
servisesRef.AddControllersWithViews();
servisesRef.AddSingleton<IRepository<EmployeViewModel>, EmployeRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "login",
        pattern: "login",
        defaults: new { controller = "Home", action = "Login" }
    );

    endpoints.MapControllerRoute(
        name: "blog",
        pattern: "blog",
        defaults: new { controller = "Home", action = "Blog", }
    );
    endpoints.MapControllerRoute(
        name: "blog-single",
        pattern: "blog/signle",
        defaults: new { controller = "Home", action = "BlogSingle" }
    );

    endpoints.MapControllerRoute(
        name: "cart",
        pattern: "cart",
        defaults: new { controller = "Home", action = "Cart" }
    );

    endpoints.MapControllerRoute(
        name: "checkout",
        pattern: "checkout",
        defaults: new { controller = "Home", action = "Checkout" }
    );

    endpoints.MapControllerRoute(
        name: "contactUs",
        pattern: "contactUs",
        defaults: new { controller = "Home", action = "ContactUs" }
    );

    endpoints.MapControllerRoute(
        name: "product-details",
        pattern: "product-details",
        defaults: new { controller = "Home", action = "ProductDetails" }
    );

    endpoints.MapControllerRoute(
        name: "shop",
        pattern: "shop",
        defaults: new { controller = "Home", action = "Shop" }
    );

    endpoints.MapControllerRoute(
        name: "404",
        pattern: "404",
        defaults: new { controller = "Home", action = "PageNotFound" }
    );


    endpoints.MapDefaultControllerRoute();
});

app.Run();