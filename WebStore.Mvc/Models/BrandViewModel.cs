using WebStore.Mvc.Domain.Interfaces;

namespace WebStore.Mvc.Models
{
    public class BrandViewModel: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
        public int Order { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
