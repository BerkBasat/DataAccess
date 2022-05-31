using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}
