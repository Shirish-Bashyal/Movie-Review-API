namespace Movie_Review_API.Models
{
    public class Country
    {
       public int Id { get; set; }
       public string Name { get; set; }

      public ICollection <Movie> Movies { get; set; }





    }
}
