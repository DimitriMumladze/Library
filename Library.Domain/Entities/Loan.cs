namespace LibraryManagement.Domain.Entities;

public class Loan
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public decimal FineAmount { get; set; }
    public LoanStatus Status { get; set; }

    // Navigation properties
    public Book Book { get; set; }
    public Member Member { get; set; }
    public Payment Payment { get; set; }
}
