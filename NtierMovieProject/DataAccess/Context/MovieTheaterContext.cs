using DataAccess.Entity;
using System.Data.Entity;


namespace DataAccess.Context
{
    public class MovieTheaterContext:DbContext
    {
        public MovieTheaterContext()
        {
            Database.Connection.ConnectionString = "server=FATIH\\SQLEXPRESS;database=CodeFirstMovieDB;uid=sa;pwd=123";
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MoviesAndCategories> MoviesAndCategories { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Saloon> Saloons { get; set; }

        public DbSet<Theater> Theaters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            
            //MoviesandCategories
            modelBuilder.Entity<MoviesAndCategories>().HasKey(x => new { x.CategoryId, x.MovieId });
            base.OnModelCreating(modelBuilder);

            //Movies
            modelBuilder.Entity<Movie>()
                .Property(x => x.MovieName)
                .HasMaxLength(250)
                .IsRequired();

            //Categories
            modelBuilder.Entity<Category>()
                .Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
