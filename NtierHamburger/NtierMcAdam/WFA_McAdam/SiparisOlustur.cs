using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Service;
using DataAccess.Model.Entity;
using DataAccess.Model.Context;

namespace WFA_McAdam
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        BurgerContext db = new BurgerContext();

        //public static List<HamburgerMenu> menuListesi = new List<HamburgerMenu>()
        //{
        //    new HamburgerMenu{Ad="Whooper",Fiyat=20},
        //    new HamburgerMenu{Ad="BigMac",Fiyat=35},
        //    new HamburgerMenu{Ad="Tavuklu",Fiyat=20}

        //};

        //public static List<Ekstra> ekstraListesi = new List<Ekstra>()
        //{
        //    new Ekstra{Ad="Ketçap",Fiyat=2},
        //    new Ekstra{Ad="Mayonex",Fiyat=2.5m},
        //    new Ekstra{Ad="Ballı Hardal",Fiyat=3},
        //    new Ekstra{Ad="Barbekü",Fiyat=2},
        //    new Ekstra{Ad="Cheddar Sos",Fiyat=5}
        //};

        public static List<Siparis> siparisListesi = new List<Siparis>();

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            rbKucuk.Checked = true;
            nudAdet.Value = 1;
            foreach (HamburgerMenu menu in db.Menus)
            {
                cmbMenu.Items.Add(menu);
            }

            foreach (Ekstra ekstra in db.Extras)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstra.Ad;
                chk.Tag = ekstra;
                flowLayoutPanel1.Controls.Add(chk);
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Menu = (HamburgerMenu)cmbMenu.SelectedItem;

            if (rbKucuk.Checked)
            {
                siparis.Boyut = Boyut.Küçük;
            }else if (rbOrta.Checked)
            {
                siparis.Boyut = Boyut.Orta;
            }
            else if (rbBuyuk.Checked)
            {
                siparis.Boyut = Boyut.Büyük;
            }

            siparis.Ekstra = new List<Ekstra>();

            foreach (CheckBox chk in flowLayoutPanel1.Controls)
            {
                if (chk.Checked)
                {
                    Ekstra ekstra = (Ekstra)chk.Tag;
                    siparis.Ekstra.Add(ekstra);
                }
            }
            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();
            listBox1.Items.Add(siparis);
            TutarHesapla();
        }

        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               Siparis siparis = (Siparis)listBox1.Items[i];
               toplamTutar+= siparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı :" + TutarHesapla().ToString("C2") + " satın almayı tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Siparis siparis = (Siparis)listBox1.Items[i];
                    siparisListesi.Add(siparis);
                }

                Odeme odemeForm = new Odeme();
                odemeForm.Show();

                listBox1.Items.Clear();
                lblToplamTutar.Text = "0 TL";
            }
           
        }
    }
}
