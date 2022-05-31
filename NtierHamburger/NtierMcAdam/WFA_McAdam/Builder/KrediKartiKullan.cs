using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdam.Builder
{
    public class KrediKartiKullan
    {
        public void KartKullan(KrediKartiBuilder Kart)
        {
            Kart.BankaAdi();
            Kart.KartTip();
        }
    }
}
