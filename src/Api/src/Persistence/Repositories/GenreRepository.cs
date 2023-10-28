using Libralink.Application.Repositories;
using Libralink.Domain;

using Microsoft.EntityFrameworkCore;

namespace Libralink.Persistence.Repositories
{
    public sealed class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Genre?> GetAsync(Guid id)
        {
            return await _context.Genres.FindAsync(id);
        }

        public async Task<IList<Genre>> GetAllAsync(int offset, int limit)
        {
            return await _context.Genres.Skip(offset).Take(limit).ToListAsync();
        }

        public async Task<Guid> AddAsync(Genre genre)
        {
            var entry = _context.Genres.Add(genre);
            await _context.SaveChangesAsync();
            return entry.Entity.Id;
        }

        public async Task UpdateAsync(Genre genre)
        {
            var entry = _context.Genres.Update(genre);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre is null)
            {
                throw new ArgumentException($"Genre with id {id} not found.");
            }

            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }
    }
}
