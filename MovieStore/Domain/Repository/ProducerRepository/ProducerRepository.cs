using Blazor.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository.ProducerRepository
{
    internal class ProducerRepository : IProducerRepository
    {
        private readonly AppDbContext _context;
        public ProducerRepository(AppDbContext context) {  _context = context; }
        public async Task<bool> AddNewProducerAsync(Producer producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProducerAsync(Producer producer)
        {
            _context.Producers.Remove(producer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Producer>> GetAllProducersAsunc()
        {
            return await _context.Producers.ToListAsync();
        }

        public async Task<Producer> GetProducerByIdAsync(int id)
        {
            Producer producer = await _context.Producers.FirstOrDefaultAsync(p => p.Id == id);
            return producer;
        }

        public async Task<bool> UpdateProducerContentAsync(Producer producer)
        {
           _context.Producers.Update(producer);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
