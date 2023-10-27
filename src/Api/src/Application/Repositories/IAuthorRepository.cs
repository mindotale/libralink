using Libralink.Domain;

namespace Libralink.Application.Repositories;

public interface IAuthorRepository
{
    public Task<Author?> GetAsync(Guid id);

    public Task<IList<Author>> GetAllAsync(int offset, int limit);

    public Task<Guid> AddAsync(Author author);

    public Task UpdateAsync(Author author);

    public Task DeleteAsync(Guid id);
}
