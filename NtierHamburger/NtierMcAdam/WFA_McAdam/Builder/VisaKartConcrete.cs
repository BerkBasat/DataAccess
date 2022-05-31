using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam.Builder
{
    public class VisaKartConcrete:KrediKartiBuilder
    {
        public VisaKartConcrete()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Ziraat Bankası";
        }

        public override void KartTip()
        {
            kart.KartTip = "Visa";
        }
    }
}
