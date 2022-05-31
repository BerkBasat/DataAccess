using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category:BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Maping
        public List<MoviesAndCategories> moviesAndCategories { get; set; }
    }
}
