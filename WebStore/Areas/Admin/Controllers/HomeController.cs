using Microsoft.AspNetCore.Mvc;
using WebStore.DomainNew.Filters;
using WebStore.Infrastructure.Interfaces;
using WebStore.DomainNew.Entities;
using Microsoft.AspNetCore.Authorization;
using WebStore.DomainNew.Models;
using WebStore.Models.Product;

namespace WebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IProductData _productData;

        public HomeController(IProductData productData)
        {
            _productData = productData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            var products = _productData.GetProducts(new ProductFilter());
            return View(products);
        }

        //[Route("delete/{id}")]
        public IActionResult DeLete(int id)
        {
            _productData.Delete(id);
            return RedirectToAction(nameof(Index));
        }


        //[Route("edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            Product model;
            if (id.HasValue)
            {
                model = _productData.GetProductById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();
            }
            else
            {
                model = new Product();
            }
            return View(model);
        }

        [HttpPost]
        //[Route("edit/{id?}")]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id > 0)
                {
                    var product = _productData.GetProductById(model.Id);
                    if (ReferenceEquals(product, null))
                        return NotFound();
                    product.Name = model.Name;
                  
                    //product.Brand = model.Brand;
                    //product.Section = model.Section;
                    product.Price = model.Price;
                    //product.ImageUrl = model.ImageUrl;
                    product.BrandId = model.BrandId;
                    product.SectionId = model.SectionId;
                }
                else
                {
                    _productData.AddNew(model);
                }
                _productData.Edit();
                return RedirectToAction(nameof(Index));
            }
            else return View();

        }
    }
}