using LibraryManagement.Domain.Enumerations;
using System.ComponentModel;

namespace LibraryManagement.Domain.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public string Description { get; set; } 
    public int AvailableCopies { get; set; }
    public int TotalCopies { get; set; }
    public BookStatus Status { get; set; }
    // Navigation Properties
    public ICollection<Author> Authors { get; set; }
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public ICollection<Loan> Loans { get; set; }
    public ICollection<Reservation> Reservations { get; set; }

}
