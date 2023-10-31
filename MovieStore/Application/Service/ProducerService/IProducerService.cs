using Domain.Models;


namespace Application.Service.ProducerService
{
    public interface IProducerService
    {
        Task<List<Producer>> GetAllProducersAsunc();
        Task<bool> AddNewProducerAsync(Producer producer);
        Task<Producer> GetProducerByIdAsync(int id);
        Task<bool> UpdateProducerContentAsync(Producer producer);
        Task<bool> DeleteProducerAsync(Producer producer);
    }
}
