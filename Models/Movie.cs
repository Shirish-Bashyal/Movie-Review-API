namespace Movie_Review_API.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }   
        public double rating { get; set; }


        public Genre Genre { get; set; }
        public Director Director { get; set; }
        public Country Country { get; set; }
        public ICollection<Reviews> Reviews { get; set; }


    }
}
