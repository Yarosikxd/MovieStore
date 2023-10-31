using Domain.Models;
using Domain.Repository.MovieRepository;

namespace Application.Service.MovieService
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;
        public MovieService(IMovieRepository repository) {  _repository = repository; }
        public virtual async Task<bool> AddNewMovieAsync(Movie movie)
        {
            try
            {
                return await _repository.AddNewMovieAsync(movie);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteMovieAsync(Movie movie)
        {
            try
            {
                return await _repository.DeleteMovieAsync(movie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<List<Movie>> GetAllMoviesAsunc()
        {
            try
            {
                return await _repository.GetAllMoviesAsunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            try
            {
                return await _repository.GetMovieByIdAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> UpdateMovieContentAsync(Movie movie)
        {
            try
            {
                return await _repository.UpdateMovieContentAsync(movie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
