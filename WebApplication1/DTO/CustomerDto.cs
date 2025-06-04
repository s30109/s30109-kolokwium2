using WebApplication1.Models;

namespace WebApplication1.DTO;

public class CustomerDto
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? PhoneNumber { get; set; } = null!;
    
    public List<PurchasedTicketDto> Purchases { get; set; } = null!;
}