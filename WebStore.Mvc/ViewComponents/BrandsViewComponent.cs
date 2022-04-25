using Microsoft.AspNetCore.Mvc;

namespace WebStore.Mvc.ViewComponents
{
    public class BrandsViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
