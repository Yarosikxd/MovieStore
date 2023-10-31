using Domain.Models;


namespace Domain.Repository.MovieRepository
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMoviesAsunc();
        Task<bool> AddNewMovieAsync(Movie movie);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<bool> UpdateMovieContentAsync(Movie movie);
        Task<bool> DeleteMovieAsync(Movie movie);
    }
}
