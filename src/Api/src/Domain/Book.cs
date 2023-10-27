namespace Libralink.Domain;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public List<Author> Authors { get; set; } = default!;
    public List<Genre> Genres { get; set; } = default!;
    public Publisher Publisher { get; set; } = default!;
    public DateTime PublishDate { get; set; }
    public string Isbn { get; set; } = default!;
    public int Pages { get; set; }
    public string Language { get; set; } = default!;
    public string Image { get; set; } = default!;
}
