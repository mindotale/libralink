namespace Libralink.Domain;

public class Publisher
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public List<Book> Books { get; set; } = default!;
}
