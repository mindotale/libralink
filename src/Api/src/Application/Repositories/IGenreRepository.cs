using Libralink.Domain;

namespace Libralink.Application.Repositories;

public interface IGenreRepository
{
    public Task<Genre?> GetAsync(Guid id);

    public Task<IList<Genre>> GetAllAsync(int offset, int limit);

    public Task<Guid> AddAsync(Genre genre);

    public Task UpdateAsync(Genre genre);

    public Task DeleteAsync(Guid id);
}
