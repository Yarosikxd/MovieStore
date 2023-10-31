using Domain.Models;
using Domain.Repository.ProducerRepository;

namespace Application.Service.ProducerService
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _repository;
        public ProducerService(IProducerRepository repository) {  _repository = repository; }
        public virtual async Task<bool> AddNewProducerAsync(Producer producer)
        {
            try
            {
                return await _repository.AddNewProducerAsync(producer);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteProducerAsync(Producer producer)
        {
            try
            {
                return await _repository.DeleteProducerAsync(producer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<List<Producer>> GetAllProducersAsunc()
        {
            try
            {
                return await _repository.GetAllProducersAsunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Producer> GetProducerByIdAsync(int id)
        {
            try
            {
                return await _repository.GetProducerByIdAsync(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> UpdateProducerContentAsync(Producer producer)
        {
            try
            {
                return await _repository.UpdateProducerContentAsync(producer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
