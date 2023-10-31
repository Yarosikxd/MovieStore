using Domain.Models;
using Domain.Repository.CinemaRepository;

namespace Application.Service.CinemaService
{
    public class CinemaService : ICinemaService
    {
        private readonly ICinemaRepository _repository;
        public CinemaService(ICinemaRepository repository) {_repository = repository;}
        public virtual async Task<bool> AddNewCinemaAsync(Cinema cinema)
        {
            try
            {
                return await _repository.AddNewCinemaAsync(cinema);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteCinemaAsync(Cinema cinema)
        {
            try
            {
                return await _repository.DeleteCinemaAsync(cinema);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<List<Cinema>> GetAllCinemasAsunc()
        {
            try
            {
                return await _repository.GetAllCinemasAsunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Cinema> GetCinemaByIdAsync(int id)
        {
            try
            {
                return await _repository.GetCinemaByIdAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> UpdateCinemaContentAsync(Cinema cinema)
        {
            try
            {
                return await _repository.UpdateCinemaContentAsync(cinema);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
