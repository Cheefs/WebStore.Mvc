using WebStore.Domain.Models.Base;

namespace WebStore.Domain.Models
{
    public class Brand : NameEntity, IOrderEntity
    {
        public int Order { get; set; }
    }
}
