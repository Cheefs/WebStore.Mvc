using Microsoft.AspNetCore.Mvc;
using WebStore.Mvc.Domain.Filters;
using WebStore.Mvc.Models;
using WebStore.Mvc.Servises.Interfaces;

namespace WebStore.Mvc.ViewComponents
{
    public class BrandsViewComponent: ViewComponent
    {
        private IProductData _productData;

        public BrandsViewComponent(IProductData productData) => _productData = productData;

        public IViewComponentResult Invoke()
        {
            return View(GetAll());
        }

        private IEnumerable<BrandViewModel> GetAll()
        {
            var result = from el in _productData.GetBrands()
                         orderby el.Order
                         select new BrandViewModel()
                         {
                             Id = el.Id,
                             Name = el.Name,
                             Order = el.Order,
                             ProductsCount = _productData.GetProducts(new ProductFilter { BrandId = el.Id }).Count()
                         };

            return result.ToList();
        }
    }
}
