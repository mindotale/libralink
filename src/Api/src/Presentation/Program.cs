using Libralink.Application.Repositories;
using Libralink.Domain;
using Libralink.Persistence;
using Libralink.Presentation.Configuration;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistence(builder.Configuration).AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();
    dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
}

// Configure the HTTP request pipeline.
app.MapGraphQL();

app.UseHttpsRedirection();

app.Run();

public class Query
{
    public Book GetBook()
    {
        return new Book() { Title = "C# in depth." };
    }
}
