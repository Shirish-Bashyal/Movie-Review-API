namespace Movie_Review_API.Models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
