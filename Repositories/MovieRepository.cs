using System.Collections.Generic;
using MovieRentalBackend.Models;

namespace MovieRentalBackend.Repositories
{
    public static class MovieRepository
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie { Title = "Inception", Genre = "Science Fiction", Language = "English", Director = "Christopher Nolan", YearOfRelease = 2010, Price = 7.50m },
            new Movie { Title = "Parasite", Genre = "Thriller", Language = "Korean", Director = "Bong Joon-ho", YearOfRelease = 2019, Price = 9.00m },
            new Movie { Title = "Amélie", Genre = "Romantic Comedy", Language = "French", Director = "Jean-Pierre Jeunet", YearOfRelease = 2001, Price = 6.00m },
            new Movie { Title = "Spirited Away", Genre = "Animation", Language = "Japanese", Director = "Hayao Miyazaki", YearOfRelease = 2001, Price = 5.50m },
            new Movie { Title = "The Godfather", Genre = "Crime", Language = "English", Director = "Francis Ford Coppola", YearOfRelease = 1972, Price = 8.00m },
            new Movie { Title = "City of God", Genre = "Crime", Language = "Portuguese", Director = "Fernando Meirelles", YearOfRelease = 2002, Price = 7.00m },
            new Movie { Title = "Pan's Labyrinth", Genre = "Fantasy", Language = "Spanish", Director = "Guillermo del Toro", YearOfRelease = 2006, Price = 8.50m },
            new Movie { Title = "The Shawshank Redemption", Genre = "Drama", Language = "English", Director = "Frank Darabont", YearOfRelease = 1994, Price = 6.50m },
            new Movie { Title = "The Intouchables", Genre = "Comedy-Drama", Language = "French", Director = "Olivier Nakache", YearOfRelease = 2011, Price = 7.75m },
            new Movie { Title = "Oldboy", Genre = "Action", Language = "Korean", Director = "Park Chan-wook", YearOfRelease = 2003, Price = 6.75m },
            new Movie { Title = "Crouching Tiger, Hidden Dragon", Genre = "Action", Language = "Mandarin", Director = "Ang Lee", YearOfRelease = 2000, Price = 7.25m },
            new Movie { Title = "The Grand Budapest Hotel", Genre = "Comedy", Language = "English", Director = "Wes Anderson", YearOfRelease = 2014, Price = 8.25m },
            new Movie { Title = "Life of Pi", Genre = "Adventure", Language = "English", Director = "Ang Lee", YearOfRelease = 2012, Price = 8.00m },
            new Movie { Title = "Memories of Murder", Genre = "Crime", Language = "Korean", Director = "Bong Joon-ho", YearOfRelease = 2003, Price = 6.25m },
            new Movie { Title = "The Lives of Others", Genre = "Drama", Language = "German", Director = "Florian Henckel von Donnersmarck", YearOfRelease = 2006, Price = 7.50m },
            new Movie { Title = "Her", Genre = "Science Fiction", Language = "English", Director = "Spike Jonze", YearOfRelease = 2013, Price = 8.75m },
            new Movie { Title = "The Secret in Their Eyes", Genre = "Mystery", Language = "Spanish", Director = "Juan José Campanella", YearOfRelease = 2009, Price = 7.25m },
            new Movie { Title = "Let the Right One In", Genre = "Horror", Language = "Swedish", Director = "Tomas Alfredson", YearOfRelease = 2008, Price = 6.50m },
            new Movie { Title = "Run Lola Run", Genre = "Thriller", Language = "German", Director = "Tom Tykwer", YearOfRelease = 1998, Price = 5.75m },
            new Movie { Title = "The Hunt", Genre = "Drama", Language = "Danish", Director = "Thomas Vinterberg", YearOfRelease = 2012, Price = 7.50m },
            new Movie { Title = "A Separation", Genre = "Drama", Language = "Persian", Director = "Asghar Farhadi", YearOfRelease = 2011, Price = 7.75m }
        };

        public static List<Movie> GetAllMovies()
        {
            return Movies;
        }

        public static Movie? GetMovieByTitle(string title)
        {
            return Movies.FirstOrDefault(movie => movie.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }

        // Search method that can filter by title, genre, director, or year
        public static IEnumerable<Movie> SearchMovies(string? title, string? genre, string? director, int? yearOfRelease)
        {
            return Movies.Where(m =>
                (string.IsNullOrEmpty(title) || m.Title.Contains(title, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(genre) || m.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(director) || m.Director.Contains(director, StringComparison.OrdinalIgnoreCase)) &&
                (!yearOfRelease.HasValue || m.YearOfRelease == yearOfRelease)
            ).ToList();
        }

        public static void UpdateStock(string title, int amount)
        {
            var movie = GetMovieByTitle(title);
            if (movie != null)
            {
                movie.Stock += amount;  // Adjust stock, can be negative for checkout
            }
        }
    }
}
