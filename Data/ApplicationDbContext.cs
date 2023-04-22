using Microsoft.EntityFrameworkCore;

namespace Movie_Review_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                                            : base(options)
        { }
        
        public DbSet<Movie_Review_API.Models.Movie> tbl_Movie { get; set; }
        public DbSet<Movie_Review_API.Models.Country> tbl_Country { get; set; }

        public DbSet<Movie_Review_API.Models.Director> tbl_Director { get; set; }

        public DbSet<Movie_Review_API.Models.Genre> tbl_Genre { get; set; }

        public DbSet<Movie_Review_API.Models.Reviewer> tbl_Reviewer { get; set; }

        public DbSet<Movie_Review_API.Models.Reviews> tbl_Reviews { get; set; }





    }
}
