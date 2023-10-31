using Domain.Models;


namespace Application.Service.MovieService
{
    public interface IMovieService
    {
        Task<List<Movie>> GetAllMoviesAsunc();
        Task<bool> AddNewMovieAsync(Movie movie);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<bool> UpdateMovieContentAsync(Movie movie);
        Task<bool> DeleteMovieAsync(Movie movie);
    }
}
