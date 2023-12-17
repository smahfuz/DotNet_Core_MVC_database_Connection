using Microsoft.EntityFrameworkCore;

namespace SecondPractice.DBContext
{
    public class MulKajDBContext : DbContext
    {
        public MulKajDBContext(DbContextOptions options) : base(options) { }

        public DbSet<MyDataTypesAre> elomelo { get; set; }
    }
}
