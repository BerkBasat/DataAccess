using DataAccess.Context;
using DataAccess.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Service
{
    public class SaloonService
    {
        MovieTheaterContext db = new MovieTheaterContext();

        //Create
        public string CreateSaloon(Saloon saloon)
        {
            try
            {
                db.Saloons.Add(saloon);
                db.SaveChanges();
                return "salon eklendi";
            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }


        //List
        public List<Saloon> SaloonList()
        {
            return db.Saloons.ToList();
        }

        //Update
        public string UpdateSaloon(Saloon saloon)
        {
            try
            {
                //Saloon updated = db.Saloons.Find(saloon.ID);
                //updated.Capacity = saloon.Capacity;
                //updated.Name = saloon.Name;

                //db.SaveChanges();
                db.Entry(saloon).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "salon güncellendi";
            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }

        //Delete

        public string DeleteSaloon(int id)
        {
            try
            {
                Saloon deleted = db.Saloons.Find(id);
                if (deleted != null)
                {
                    db.Saloons.Remove(deleted);
                    db.SaveChanges();
                    return "salon silindi!";
                }
                else
                {
                    return "böyle bir salon mevcut değil!";
                }
            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }

        

    }
}
