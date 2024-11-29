using LibraryManagement.Domain.Enumerations;

namespace LibraryManagement.Domain.Entities;

public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public MembershipType MembershipType { get; set; }
    public MembershipStatus MembershipStatus { get; set; }
    public int MaxAllowedBooks { get; set; }
}

