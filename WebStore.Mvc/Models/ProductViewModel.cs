using WebStore.Mvc.Domain.Interfaces;

namespace WebStore.Mvc.Models
{
    public class ProductViewModel: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
