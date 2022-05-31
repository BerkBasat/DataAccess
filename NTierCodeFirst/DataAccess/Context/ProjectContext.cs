using System.Data.Entity;
using DataAccess.Entity;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=FATIH\\SQLEXPRESS;database=NTierCodeFirstDB;uid=sa;pwd=123";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
