using Libralink.Application.Repositories;
using Libralink.Domain;

using Microsoft.EntityFrameworkCore;

namespace Libralink.Persistence.Repositories;

public sealed class AuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _context;

    public AuthorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Author?> GetAsync(Guid id)
    {
        return await _context.Authors.FindAsync(id);
    }

    public async Task<IList<Author>> GetAllAsync(int offset, int limit)
    {
        return await _context.Authors.Skip(offset).Take(limit).ToListAsync();
    }

    public async Task<Guid> AddAsync(Author author)
    {
        var entry = _context.Authors.Add(author);
        await _context.SaveChangesAsync();
        return entry.Entity.Id;
    }

    public async Task UpdateAsync(Author author)
    {
        var entry = _context.Authors.Update(author);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var author = await _context.Authors.FindAsync(id);
        if (author is null)
        {
            throw new ArgumentException($"Author with id {id} not found.");
        }

        _context.Authors.Remove(author);
        await _context.SaveChangesAsync();
    }
}
