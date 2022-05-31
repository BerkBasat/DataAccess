using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;

namespace BLL.Interface
{
    public interface IAdmin<T> where T:BaseEntity
    {
        string Create(T model);

        List<T> GetList();

        string Update(T model);

        string Delete(int id);

    }
}
