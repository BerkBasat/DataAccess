using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Entity;
using BLL.Interface;
using DataAccess.Model.Context;

namespace BLL.Service
{
    public class AppUserService<T> : IUser<T> where T : BaseEntity
    {

        ProjectContext db = new ProjectContext();


        public List<T> GetList()
        {
            return db.Set(typeof(T)).Cast<T>().ToList();
        }
    }
}
