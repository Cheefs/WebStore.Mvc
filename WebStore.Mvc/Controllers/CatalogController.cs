using WebStore.Mvc.Servises.Interfaces;
using WebStore.Mvc.Domain.Filters;
using WebStore.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.Mvc.Controllers
{
    public class CatalogController : Controller
    {
        private IProductData _productData;

        public CatalogController(IProductData productData) => _productData = productData;

        public IActionResult Index(int? sectionId, int? brandId)
        {
            var products = _productData.GetProducts(new ProductFilter
            {
                BrandId = brandId,
                SectionId = sectionId,
            });

            var catalog = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products.Select(product => new ProductViewModel { 
                    Id = product.Id,
                    Name = product.Name,
                    ImageUrl = product.ImageUrl,
                    Order = product.Order,
                    Price = product.Price
                }).OrderBy(p => p.Order).ToList(),
            };

            return View(catalog);
        }
    }
}
