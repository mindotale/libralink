using Libralink.Application.Repositories;
using Libralink.Persistence;
using Libralink.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;

namespace Libralink.Presentation.Configuration;

public static class PersistenceConfigurationExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext(configuration).AddRepositories();
    }

    private static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(
            options =>
            {
                var connectionString = configuration.GetValue<string>("Postgres:ConnectionString")!;
                options.UseNpgsql(connectionString);
            });

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services.AddTransient<IBookRepository, BookRepository>()
            .AddTransient<IAuthorRepository, AuthorRepository>()
            .AddTransient<IGenreRepository, GenreRepository>()
            .AddTransient<IPublisherRepository, PublisherRepository>();
    }
}
