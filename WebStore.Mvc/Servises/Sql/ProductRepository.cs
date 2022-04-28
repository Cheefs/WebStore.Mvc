using WebStore.Mvc.Servises.Interfaces;
using WebStore.Mvc.Domain.Entities;
using WebStore.Mvc.Domain.Filters;
using WebStore.Mvc.DataAccessLayer;

namespace WebStore.Mvc.Servises.Sql
{
    public class ProductRepository: IProductData
    {
        private readonly WebStoreDbContext _context;

        public ProductRepository(WebStoreDbContext webStoreDbContext)
        {
            _context = webStoreDbContext;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter? filter)
        {
            var products = _context.Products.AsQueryable();
            if (filter.SectionId.HasValue)
                products = products.Where(p => p.SectionId.Equals(filter.SectionId));
            if (filter.BrandId.HasValue)
                products = products.Where(p => p.BrandId.HasValue && p.BrandId.Value.Equals(filter.BrandId.Value));

            return products.ToList();
        }
    }
}
