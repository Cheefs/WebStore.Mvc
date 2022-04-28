namespace WebStore.Mvc.DataAccessLayer
{
    public class DbInitializer
    {
        public static void Initialize(WebStoreDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
