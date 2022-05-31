using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Context;
using DataAccess.Model.Entity;

namespace BLL.Service
{
    public class EkstraService
    {
        BurgerContext db = new BurgerContext();

        public string AddExtra(Ekstra ekstra)
        {
            try
            {
                db.Extras.Add(ekstra);
                db.SaveChanges();
                return $"{ekstra.Ad} - {ekstra.Fiyat}";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Ekstra> ExtraList()
        {
            return db.Extras.ToList();
        }

        //Guncelleme
        public string UpdateExtra(Ekstra ekstra)
        {

            Ekstra updated = db.Extras.FirstOrDefault(x => x.ID == ekstra.ID);
            updated.Ad = ekstra.Ad;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme
        public string DeleteExtra(int id)
        {
            try
            {
                Ekstra silinecek = db.Extras.Find(id);
                db.Extras.Remove(silinecek);
                db.SaveChanges();
                return "Silme işlemi gerçekleştirildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
