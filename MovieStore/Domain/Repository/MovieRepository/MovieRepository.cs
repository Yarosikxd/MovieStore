using Blazor.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository.MovieRepository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;
        public MovieRepository(AppDbContext context) {  _context = context; }

        public async Task<bool> AddActorToMovieAsync(int movieId, int actorId)
        {
            var movie =  await _context.Movies.FirstOrDefaultAsync(m => m.Id == movieId);
            var actor = await _context.Actors_Movies.FirstOrDefaultAsync(a => a.ActorId == actorId);
            movie.Actors_Movies.Add(actor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddNewMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMovieAsync(Movie movie)
        {
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Movie>> GetAllMoviesAsunc()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            return movie;
        }

        public async Task<bool> UpdateMovieContentAsync(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
