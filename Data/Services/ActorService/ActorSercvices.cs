using eTickets_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTickets_2.Data.Services.ActorService
{
    public class ActorSercvices : IActorServices
    {
        private readonly dbContext _context;
        public ActorSercvices(dbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            _context.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var actors = _context.actors.FirstOrDefault(x => x.Id == id);
            if (actors != null)
            {
                _context.actors.Remove(actors);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _context.actors.ToListAsync();
        }

        public Actor GetById(int id)
        {
            return _context.actors.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Actor actor)
        {
            _context.Update(actor);
            _context.SaveChanges();
        }
    }
}
