using WebStore.Mvc.Domain.Entities;
using WebStore.Mvc.Domain.Filters;

namespace WebStore.Mvc.Servises.Interfaces
{
    public interface IProductData
    {
        public IEnumerable<Section> GetSections();
        public IEnumerable<Brand> GetBrands();
        public IEnumerable<Product> GetProducts(ProductFilter? filter);
    }
}
