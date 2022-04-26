using WebStore.Mvc.Servises.Interfaces;
using WebStore.Mvc.Domain.Entities;
using WebStore.Mvc.Domain.Filters;
using WebStore.Mvc.DataAccessLayer;

namespace WebStore.Mvc.Servises.InMemory
{
    public class ProductRepository: IProductData
    {
        private readonly WebStoreDbContext _context;

        private IEnumerable<Product> _products;

        public ProductRepository(WebStoreDbContext webStoreDbContext)
        {
            _context = webStoreDbContext;
        
            _products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product1.jpg",
                    Order = 0,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product2.jpg",
                    Order = 1,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product3.jpg",
                    Order = 2,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product4.jpg",
                    Order = 3,
                    SectionId = 2,
                    BrandId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product5.jpg",
                    Order = 4,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 6,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product6.jpg",
                    Order = 5,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 7,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product7.jpg",
                    Order = 6,
                    SectionId = 2,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 8,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product8.jpg",
                    Order = 7,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 9,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product9.jpg",
                    Order = 8,
                    SectionId = 25,
                    BrandId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product10.jpg",
                    Order = 9,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 11,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product11.jpg",
                    Order = 10,
                    SectionId = 25,
                    BrandId = 3
                },
                new Product()
                {
                    Id = 12,
                    Name = "Easy Polo Black Edition",
                    Price = 1025,
                    ImageUrl = "product12.jpg",
                    Order = 11,
                    SectionId = 25,
                    BrandId = 3
                },
            };
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
            var products = _products;
            if (filter.SectionId.HasValue)
                products = products.Where(p => p.SectionId.Equals(filter.SectionId)).ToList();
            if (filter.BrandId.HasValue)
                products = products.Where(p => p.BrandId.HasValue && p.BrandId.Value.Equals(filter.BrandId.Value)).ToList();
            return products;
        }
    }
}
