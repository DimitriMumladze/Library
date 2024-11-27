namespace LibraryManagement.Domain.Entities;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }

    // Navigation properties
    public ICollection<Book> Books { get; set; }
}
