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

namespace WFA_McAdam
{
    public partial class EkstraOlustur : Form
    {
        public EkstraOlustur()
        {
            InitializeComponent();
        }

        EkstraService ekstraService = new EkstraService();
        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();
            ekstra.Ad = txtEkstra.Text;
            ekstra.Fiyat = nudEkstraFiyat.Value;

            if (txtEkstra.Text != null || nudEkstraFiyat.Value != 0)
            {
                string result = ekstraService.AddExtra(ekstra);
            }
            else
            {
                MessageBox.Show("Boş değer eklenemez!");
            }

            txtEkstra.Text = "";
            nudEkstraFiyat.Value = 0;

            MessageBox.Show("Ekstra Eklendi!");
        }
    }
}
