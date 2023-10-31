using Domain.Models;

namespace Domain.Repository.CinemaRepository
{
    public interface ICinemaRepository
    {
        Task<List<Cinema>> GetAllCinemasAsunc();
        Task<bool> AddNewCinemaAsync(Cinema cinema);
        Task<Cinema> GetCinemaByIdAsync(int id);
        Task<bool> UpdateCinemaContentAsync(Cinema cinema);
        Task<bool> DeleteCinemaAsync(Cinema cinema);
    }
}
