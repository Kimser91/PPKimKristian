namespace PPKimKristian;

public class Main
{
    private List<Movie> movies;

    public Main()
    {
        movies = new List<Movie>()
        {
            new Movie("Lord of the rings", "2001", "Awesome movie", "Adventure", "Peter Jackson"),
            new Movie("Star Wars", "1974","Cool movie","Fantasy", "George Lucas"),

        };

    }
    public void ShowMovies()
    {
        for (int i = 0; i < movies.Count; i++)
        {
            //Console.WriteLine(movies[i].Title + movies[i].ReleaseYear + movies[i].Description + movies[i].Genre);
            //Console.WriteLine($"Title: {movies[i].Title} Year: {movies[i].ReleaseYear} Description: {movies[i].Description} Genre: {movies[i].Genre}");
            Console.WriteLine($"{i + 1} Title: {movies[i].Title}");
        }

        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(movies[input - 1].Title);
    }
}