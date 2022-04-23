using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [Route("/blog")]
        public IActionResult Blog() => View();

        [Route("/blog-single")]
        public IActionResult BlogSingle() => View();

        [Route("/cart")]
        public IActionResult Cart() => View();

        [Route("/checkout")]
        public IActionResult Checkout() => View();

        [Route("/contactUs")]
        public IActionResult ContactUs() => View();

        [Route("/product-details")]
        public IActionResult ProductDetails() => View();

        [Route("/shop")]
        public IActionResult Shop() => View();

        [Route("/404")]
        public IActionResult PageNotFound() => View();
    }
}
