using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam.Builder
{
    public class MasterKartConcrete : KrediKartiBuilder
    {
        public MasterKartConcrete()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Türkiye İş Bankası";
        }

        public override void KartTip()
        {
            kart.KartTip = "Master";
        }
    }
}
