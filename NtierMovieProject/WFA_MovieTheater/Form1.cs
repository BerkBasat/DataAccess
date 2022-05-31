using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entity;
using BLL.Repository;

namespace WFA_MovieTheater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseRepository<Category> categoryRepository = new BaseRepository<Category>();

        BaseRepository<Movie> movieRepository = new BaseRepository<Movie>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Category> categories = new List<Category>()
            //{
            //    new Category{Name="Action"},
            //    new Category{Name="Drama"},
            //    new Category{Name="Horror"}
            //};

            //foreach (Category category in categories)
            //{
            //    MessageBox.Show(categoryRepository.Create(category));
            //}
            pnlLeftMenu.BackColor = Color.FromArgb(26, 60, 64);
            pnlContent.BackColor = Color.FromArgb(237, 230, 219);


        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            this.pnlContent.Controls.Add(movieForm.pnlMovie);
            btnMovie.BackColor = Color.Black;
            btnMovie.ForeColor = Color.White;
        }
    }
}
