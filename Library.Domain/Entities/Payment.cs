namespace LibraryManagement.Domain.Entities;

public class Payment
{
    public int Id { get; set; }
    public int MemberId { get; set; }
    public int? LoanId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus Status { get; set; }

    // Navigation properties
    public Member Member { get; set; }
    public Loan Loan { get; set; }
}

