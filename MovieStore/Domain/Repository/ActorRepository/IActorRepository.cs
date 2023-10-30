using Domain.Models;

namespace Domain.Repository.ActorRepository
{
    public interface IActorRepository
    {
        Task<List<Actor>> GetAllActorsAsunc();
        Task<bool> AddNewActorAsync(Actor actor);
        Task<Actor> GetActorByIdAsync(int id);
        Task<bool> UpdateActorContentAsync(Actor actor);
        Task<bool> DeleteActorAsync(Actor actor);
    }
}
