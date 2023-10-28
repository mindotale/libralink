namespace Libralink.Domain;

public class Author
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime BirthDate { get; set; }
    public string Image { get; set; } = default!;
}
