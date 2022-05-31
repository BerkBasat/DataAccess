using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Model.Context;
using DataAccess.Model.Entity;

namespace BLL.Service
{
    public class HamburgerMenuService
    {
        BurgerContext db = new BurgerContext();

        public string CreateMenu(HamburgerMenu menu)
        {
            try
            {
                db.Menus.Add(menu);
                db.SaveChanges();
                return $"{menu.Ad} - {menu.Fiyat}";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<HamburgerMenu> MenuList()
        {
            return db.Menus.ToList();
        }

        //Guncelleme
        public string UpdateMenu(HamburgerMenu menu)
        {

            HamburgerMenu updated = db.Menus.FirstOrDefault(x => x.ID == menu.ID);
            updated.Ad = menu.Ad;

            db.SaveChanges();
            return "Guncelleme tamamlandı";
        }

        //Silme
        public string DeleteMenu(int id)
        {
            try
            {
                HamburgerMenu silinecek = db.Menus.Find(id);
                db.Menus.Remove(silinecek);
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
