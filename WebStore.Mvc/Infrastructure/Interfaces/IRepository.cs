namespace WebStore.Mvc.Infrastructure.Interfaces
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();

        public T? GetById(int? id);

        public bool Delete(int id);

        public bool Update(T data);

        public int Add(T data);
    }
}
