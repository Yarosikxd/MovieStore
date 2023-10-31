using Domain.Models;
using Domain.Repository.ActorRepository;

namespace Application.Service.ActorSerice
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _repository;
        public ActorService(IActorRepository repository) {  _repository = repository; }
        public virtual async Task<bool> AddNewActorAsync(Actor actor)
        {
            try
            {
                return await _repository.AddNewActorAsync(actor);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            } 
        }

        public async Task<bool> DeleteActorAsync(Actor actor)
        {
            try
            {
                return await _repository.DeleteActorAsync(actor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            try
            {
                return await _repository.GetActorByIdAsync(id);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<List<Actor>> GetAllActorsAsunc()
        {
            try
            {
                return await _repository.GetAllActorsAsunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> UpdateActorContentAsync(Actor actor)
        {
            try
            {
                return await _repository.UpdateActorContentAsync(actor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
