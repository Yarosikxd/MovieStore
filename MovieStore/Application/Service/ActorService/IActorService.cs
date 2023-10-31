using Domain.Models;

namespace Application.Service.ActorSerice
{
    public interface IActorService
    {
        Task<List<Actor>> GetAllActorsAsunc();
        Task<bool> AddNewActorAsync(Actor actor);
        Task<Actor> GetActorByIdAsync(int id);
        Task<bool> UpdateActorContentAsync(Actor actor);
        Task<bool> DeleteActorAsync(Actor actor);
    }
}
