using Domain.Models;


namespace Domain.Repository.ProducerRepository
{
    public interface IProducerRepository
    {
        Task<List<Producer>> GetAllProducersAsunc();
        Task<bool> AddNewProducerAsync(Producer producer);
        Task<Producer> GetProducerByIdAsync(int id);
        Task<bool> UpdateProducerContentAsync(Producer producer);
        Task<bool> DeleteProducerAsync(Producer producer);
    }
}
