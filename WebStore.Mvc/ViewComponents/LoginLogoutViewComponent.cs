using Microsoft.AspNetCore.Mvc;

namespace WebStore.Mvc.ViewComponents
{
    public class LoginLogoutViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
