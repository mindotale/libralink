using Libralink.Application.Repositories;
using Libralink.Domain;

using Microsoft.EntityFrameworkCore;

namespace Libralink.Persistence.Repositories
{
    public sealed class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book?> GetAsync(Guid id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task<IList<Book>> GetAllAsync(int offset, int limit)
        {
            return await _context.Books.Skip(offset).Take(limit).ToListAsync();
        }

        public async Task<Guid> AddAsync(Book book)
        {
            var entry = _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return entry.Entity.Id;
        }

        public async Task UpdateAsync(Book book)
        {
            var entry = _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
            {
                throw new ArgumentException($"Book with id {id} not found.");
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
