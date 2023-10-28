using Libralink.Domain;

namespace Libralink.Application.Repositories;

public interface IPublisherRepository
{
    public Task<Publisher?> GetAsync(Guid id);

    public Task<IList<Publisher>> GetAllAsync(int offset, int limit);

    public Task<Guid> AddAsync(Publisher publisher);

    public Task UpdateAsync(Publisher publisher);

    public Task DeleteAsync(Guid id);
}
