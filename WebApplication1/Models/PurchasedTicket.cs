using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

[Table("PurchasedTicket")]
[PrimaryKey(nameof(TicketConcertId), nameof(CustomerId))]
public class PurchasedTicket
{
    [ForeignKey(nameof(TicketConcertId))]
    public int TicketConcertId { get; set; }
    
    [ForeignKey(nameof(CustomerId))]
    public int CustomerId { get; set; }
    
    public DateTime PurchaseDate { get; set; }
    
    public TicketConcert TicketConcert { get; set; } = null!;
    
    public Customer Customer { get; set; } = null!;
}