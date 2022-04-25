using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Mvc.Domain.Entities
{
    public class Section: BaseEntity
    {
        public string Name { get; set; }

        public int? ParentId { get; set; }

        public int Order { get; set; }

        [ForeignKey("ParentId")]
        public virtual Section? ParentSection { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
