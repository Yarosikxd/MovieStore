using Blazor.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository.ActorRepository
{
    public class ActorRepository : IActorRepository
    {
        private readonly AppDbContext _context;
        public ActorRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddNewActorAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
           await _context.SaveChangesAsync();
           return true;
        }

        public async Task<bool> DeleteActorAsync(Actor actor)
        {
            _context.Actors.Remove(actor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            Actor actor = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return actor;
        }

        public async Task<List<Actor>> GetAllActorsAsunc()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<bool> UpdateActorContentAsync(Actor actor)
        {
            _context.Actors.Update(actor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
