


namespace BookApi.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }


        public DbSet<Book> Books => Set<Book>();
    }
}
