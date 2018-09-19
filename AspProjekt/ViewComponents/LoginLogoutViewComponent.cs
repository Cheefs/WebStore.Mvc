using Microsoft.AspNetCore.Mvc;

namespace AspProjekt.ViewComponents
{
    public class LoginLogoutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
