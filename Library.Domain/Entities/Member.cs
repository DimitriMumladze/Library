namespace LibraryManagement.Domain.Entities;

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public MembershipType MembershipType { get; set; }
    public MembershipStatus MembershipStatus { get; set; }
    public DateTime JoinDate { get; set; }
    public int MaxAllowedBooks { get; set; }

    // Navigation properties
    public ICollection<Loan> Loans { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
    public ICollection<Payment> Payments { get; set; }
}

