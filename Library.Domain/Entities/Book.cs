using LibraryManagement.Domain.Enumerations;
using System.ComponentModel;

namespace LibraryManagement.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; } 
    public bool Available { get; set; }
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }

}
