namespace WebStore.Mvc.Domain.Interfaces
{
    public interface IEntity
    {
        public int Id { get; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
