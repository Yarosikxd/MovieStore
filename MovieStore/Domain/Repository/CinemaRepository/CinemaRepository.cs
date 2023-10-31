using Blazor.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository.CinemaRepository
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly AppDbContext _context;
        public CinemaRepository(AppDbContext context) {_context = context;}
        public async Task<bool> AddNewCinemaAsync(Cinema cinema)
        {
            await _context.Cinemas.AddAsync(cinema);
            await _context.SaveChangesAsync();
            return true;
        }

       public async Task<bool> DeleteCinemaAsync(Cinema cinema)
       {
            _context.Cinemas.Remove(cinema);
            await _context.SaveChangesAsync();
            return true;
       }

        public async Task<List<Cinema>> GetAllCinemasAsunc()
        {
            return await _context.Cinemas.ToListAsync();
        }

        public async Task<Cinema> GetCinemaByIdAsync(int id)
        {
           Cinema cinema = await _context.Cinemas.FirstOrDefaultAsync(c => c.Id == id);
            return cinema;
        }
        public async Task<bool> UpdateCinemaContentAsync(Cinema cinema)
        {
            _context.Cinemas.Update(cinema);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
