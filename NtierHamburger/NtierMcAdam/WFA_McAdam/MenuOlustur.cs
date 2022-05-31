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
    public partial class MenuOlustur : Form
    {
        public MenuOlustur()
        {
            InitializeComponent();
        }

        HamburgerMenuService hamburgerMenuService = new HamburgerMenuService();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            HamburgerMenu menu = new HamburgerMenu();
            menu.Ad = txtMenuAd.Text;
            menu.Fiyat = nudMenuFiyat.Value;

            if (txtMenuAd.Text != null || nudMenuFiyat.Value != 0)
            {
                string result = hamburgerMenuService.CreateMenu(menu);
            }
            else
            {
                MessageBox.Show("Boş değer eklenemez!");
            }
            
            txtMenuAd.Text = "";
            nudMenuFiyat.Value = 0;

            MessageBox.Show("Menu Eklendi!");
        }
    }
}
