using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_McAdam.Builder;

namespace WFA_McAdam
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            KrediKartiBuilder visa = new VisaKartConcrete();
            KrediKartiKullan use = new KrediKartiKullan();

            use.KartKullan(visa);

            cmbBanka.Items.Add(visa.Kart.BankaAdi);
            cmbKart.Items.Add(visa.Kart.KartTip);


        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme İşlemi Başarıyla Gerçekleştirildi!");

            Siparisler siparisler = new Siparisler();
            this.Close();
            siparisler.Show();
        }

    }
}
