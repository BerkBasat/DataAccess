using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entity
{
    public class Siparis
    {
        public int ID { get; set; }
        public HamburgerMenu Menu { get; set; }
        public List<Ekstra> Ekstra { get; set; }
        public Boyut  Boyut { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Küçük:
                    ToplamTutar += 0;
                    break;
                case Boyut.Orta:
                    ToplamTutar += 3;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += 5;
                    break;
            }
            foreach (Ekstra ekstra in Ekstra)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar *= Adet;


        }

        public override string ToString()
        {
            if (Ekstra.Count < 1)
            {
                return $"{Menu} Menu, {Adet} Adet, {Boyut.ToString()} Toplam: {ToplamTutar.ToString("C2")}";
            }
            else
            {
                string ekstraBilgi = "";
                foreach (Ekstra ekstra in Ekstra)
                {
                    ekstraBilgi += ekstra.Ad + " ";
                }
                ekstraBilgi=ekstraBilgi.Trim();
                return $"{Menu} Menu, {Adet} Adet, {Boyut.ToString()}, Ekstra: ({ekstraBilgi}) {ToplamTutar.ToString("C2")}";
            }
        }

    }
}
