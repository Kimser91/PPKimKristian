using System.Reflection;

namespace PPKimKristian;

public class Main
{
    private List<Movie> movies;
    private int input;
    private string Title = "";
    private string ReleaseYear = "";
    private string Description = "";
    private string Genre = "";
    private string Director = "";
    
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

        Console.WriteLine("Choose movie by number");
        input = int.Parse(Console.ReadLine());

        PrintChosenMovie();
    }

    void PrintChosenMovie()
    {
        Console.WriteLine($"Title: {movies[input - 1].Title}");
        Console.WriteLine($"Year: {movies[input - 1].ReleaseYear}");
        Console.WriteLine($"Description: {movies[input - 1].Description}");
        Console.WriteLine($"Genre: {movies[input - 1].Genre}");
        Console.WriteLine($"Director: {movies[input - 1].Director}");
        Console.WriteLine();
        Console.WriteLine("Do you want to do something else? Y/N");
        var userInput = Console.ReadLine();
        switch (userInput)
        {
            case "Y":
                MenuSwitch();
                break;
            default: 
                Environment.Exit(0);
                break;
        }


    }
    
  public  void MenuSwitch()
    {
        Console.WriteLine("Welcome to the movie information database!");
        Console.WriteLine("what do you want to do?");
        Console.WriteLine("1. Show library");
        Console.WriteLine("2. Add movie to library");
        Console.WriteLine("3. Exit");
        var menuchoice = Console.ReadLine();
       
        switch (menuchoice)
        {
            case "1":
                ShowMovies();
                break;
            case "2":
                AddMovie();
                break;
            case "3":
                Environment.Exit(0);
                break;
        }

    }

    public void AddMovie()
    {
        Console.WriteLine("Write the title of the movie");
        Title = Console.ReadLine();

        Console.WriteLine("Write the year of release");
         ReleaseYear = Console.ReadLine();

        Console.WriteLine("Write a short description of the movie");
        Description = Console.ReadLine();

        Console.WriteLine("What genre is the movie?");
        Genre = Console.ReadLine();

        Console.WriteLine("Who directed the movie?");
         Director = Console.ReadLine();

        movies.Add(new Movie(Title, ReleaseYear, Description, Genre, Director));

        Console.WriteLine();
        Console.WriteLine($"Title: {movies.Last().Title}");
        Console.WriteLine($"Year: {movies.Last().ReleaseYear}");
        Console.WriteLine($"Description: {movies.Last().Description}");
        Console.WriteLine($"Genre: {movies.Last().Genre}");
        Console.WriteLine($"Director: {movies.Last().Director}");
        Console.WriteLine();


        Console.WriteLine();
        Console.WriteLine("Do you want to do something else? Y/N");
        var userInput = Console.ReadLine();
        switch (userInput)
        {
            case "Y":
                MenuSwitch();
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }


}