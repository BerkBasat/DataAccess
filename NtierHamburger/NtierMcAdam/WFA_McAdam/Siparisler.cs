using DataAccess.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdet = 0;

            if (SiparisOlustur.siparisListesi.Count > 0)
            {
                foreach (Siparis siparis in SiparisOlustur.siparisListesi)
                {
                    //ekstra adet bilgisi düzenlenecek.
                    ciro += siparis.ToplamTutar;
                    foreach (Ekstra ekstra in siparis.Ekstra)
                    {
                        ekstraMalzemeGeliri += ekstra.Fiyat;
                    }
                    ekstraMalzemeGeliri *= siparis.Adet;
                    satisAdet += siparis.Adet;
                    listBox1.Items.Add(siparis);
                }

                lblCiro.Text = ciro.ToString("C2");
                lblEkstraGelir.Text = ekstraMalzemeGeliri.ToString("C2");
                lblSatilanUrunAdet.Text = satisAdet.ToString();
                lblToplamSiparis.Text = listBox1.Items.Count.ToString();
            }



        }
    }
}
