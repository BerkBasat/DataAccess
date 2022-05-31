using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;

namespace DataAccess.Model.Context
{
    public class BurgerContext:DbContext
    {
        public BurgerContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-55FON9IT;Database=BurgerDB;Trusted_Connection=True;";
        }

        public DbSet<HamburgerMenu> Menus { get; set; }
        public DbSet<Ekstra> Extras { get; set; }
    }
}
