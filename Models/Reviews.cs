namespace Movie_Review_API.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Reviewer Reviewer { get; set; }
        public Movie Movie { get; set; }

    }
}
