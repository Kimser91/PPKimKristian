namespace PPKimKristian;

public class Movie
{
   public string Title { get; set; }
   public string ReleaseYear { get; set; }
   public string Description { get; set; }
   public string Genre { get; set; }
   public string Director { get; set; }

   public Movie(string title, string releaseYear, string description, string genre, string director)
   {
       Title = title;
       ReleaseYear = releaseYear;
       Description = description;
       Genre = genre;
       Director = director;
   }


}

