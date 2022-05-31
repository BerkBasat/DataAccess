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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //todo: her form açıldığında aşağıtya kaydırıyor. 
        //45. satır dahil edildiğinde sorun çözüldü.
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width+22;
            this.Height = _childForm.Height+60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    SiparisOlustur siparisOlustur = new SiparisOlustur();
        //    childForm(siparisOlustur);
            childForm(new SiparisOlustur());
          
        }

        private void menuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MenuOlustur());
            
        }

        private void ekstraOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new EkstraOlustur());
        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Siparisler());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
