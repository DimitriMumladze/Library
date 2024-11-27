namespace LibraryManagement.Domain.Entities;

public class Reservation
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int MemberId { get; set; }
    public DateTime ReservationDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public ReservationStatus Status { get; set; }

    // Navigation properties
    public Book Book { get; set; }
    public Member Member { get; set; }
}

