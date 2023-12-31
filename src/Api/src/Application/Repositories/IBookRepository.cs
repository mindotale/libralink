﻿using Libralink.Domain;

namespace Libralink.Application.Repositories;

public interface IBookRepository
{
    public Task<Book?> GetAsync(Guid id);

    public Task<IList<Book>> GetAllAsync(int offset, int limit);

    public Task<IList<Book>> GetAllByAuthorAsync(Guid authorId, int offset, int limit);

    public Task<IList<Book>> GetAllByGenreAsync(Guid genreId, int offset, int limit);

    public Task<IList<Book>> GetAllByPublisherAsync(Guid publisherId, int offset, int limit);

    public Task<Guid> AddAsync(Book book);

    public Task UpdateAsync(Book book);

    public Task DeleteAsync(Guid id);
}
