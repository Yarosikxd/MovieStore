using Domain.Models;


namespace Application.Service.CinemaService
{
    public interface ICinemaService
    {
        Task<List<Cinema>> GetAllCinemasAsunc();
        Task<bool> AddNewCinemaAsync(Cinema cinema);
        Task<Cinema> GetCinemaByIdAsync(int id);
        Task<bool> UpdateCinemaContentAsync(Cinema cinema);
        Task<bool> DeleteCinemaAsync(Cinema cinema);
    }
}
