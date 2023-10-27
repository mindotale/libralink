using Libralink.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

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
