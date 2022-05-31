using BLL.Repository;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MovieTheater
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
            GenerateListView();
        }
        BaseRepository<Movie> movieRepository = new BaseRepository<Movie>();
        public void GenerateListView()
        {
            
            foreach (Movie movie in movieRepository.GetList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movie.ID.ToString();
                lvi.SubItems.Add(movie.MovieName);
                lvi.SubItems.Add(movie.Description);

                listView1.Items.Add(lvi);

            }
         

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Movie movie = new Movie();
            //movie.MovieName = "Big Fish2";
            //movie.Description = "asdadad";
            //movie.Duration = TimeSpan.FromHours(01.50);

            //string result=movieRepository.Create(movie);
            //MessageBox.Show(result);
            //GenerateListView();

            Movie gelenFilm = movieRepository.FindById(4);
            gelenFilm.MovieName = "Sil Baştan";

            movieRepository.Update(gelenFilm);

            
        }
    }
}
