namespace AjaxMvc.Models
{
    public class DataService
    {

        List<Movie> Movies = new List<Movie>()
        {
            new Movie {Id = 1, Title = "Star Wars", Description = "Light sabers and action"},
            new Movie {Id = 2, Title = "Pokemon", Description = "Innocent animals forced to fight eachother for their masters enjoyment"},
            new Movie {Id = 3, Title = "Forrest Gump", Description = "Man runs cross country because hes sad"},
            new Movie {Id = 4, Title = "Lord of the rings", Description = "Monsters battle Humans for a ring"},
        };

        public Movie GetMovieById(int id)
        {
            return Movies.Where(m => m.Id == id).First();
        }
    }
}
