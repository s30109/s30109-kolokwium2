namespace WebApplication1.DTO;

public class PurchasedTicketDto
{
    public DateTime Date { get; set; }
    public double Price { get; set; }

    public TicketDto Ticket { get; set; } = null!;
    public ConcertDto Concert { get; set; } = null!;
}