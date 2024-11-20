using eTickets_2.Models;

namespace eTickets_2.Data.Services
{
    public interface IActorServices
    {
        Task<IEnumerable<Actor>> GetAll();
        void Add(Actor actor);
        Actor GetById(int id);
        void Update(Actor actor);
        void Delete(int id);
    }
}
