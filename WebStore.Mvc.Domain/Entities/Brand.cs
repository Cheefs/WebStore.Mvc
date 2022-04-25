
namespace WebStore.Mvc.Domain.Entities
{
    public class Brand: BaseEntity
    {
        public string Name { get; set; }
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
