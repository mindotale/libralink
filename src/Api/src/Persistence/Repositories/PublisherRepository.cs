using Libralink.Application.Repositories;
using Libralink.Domain;

using Microsoft.EntityFrameworkCore;

namespace Libralink.Persistence.Repositories
{
    public sealed class PublisherRepository : IPublisherRepository
    {
        private readonly ApplicationDbContext _context;

        public PublisherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Publisher?> GetAsync(Guid id)
        {
            return await _context.Publishers.FindAsync(id);
        }

        public async Task<IList<Publisher>> GetAllAsync(int offset, int limit)
        {
            return await _context.Publishers.Skip(offset).Take(limit).ToListAsync();
        }

        public async Task<Guid> AddAsync(Publisher publisher)
        {
            var entry = _context.Publishers.Add(publisher);
            await _context.SaveChangesAsync();
            return entry.Entity.Id;
        }

        public async Task UpdateAsync(Publisher publisher)
        {
            var entry = _context.Publishers.Update(publisher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var publisher = await _context.Publishers.FindAsync(id);
            if (publisher is null)
            {
                throw new ArgumentException($"Publisher with id {id} not found.");
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();
        }
    }
}
