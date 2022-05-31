using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;

namespace BLL.Interface
{
    public interface IReport
    {
        void ProductPerCategory();

        void ProductsWithLowStockNo();

        void GetLuxuriousProducts();
    }
}
