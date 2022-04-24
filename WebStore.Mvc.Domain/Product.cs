using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Mvc.Domain
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public int SectionId { get; set; }

        public int BrandId { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}
