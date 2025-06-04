using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext :DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<PurchasedTicket> PurchasedTickets { get; set; }
    public DbSet<TicketConcert> TicketConcerts { get; set; }

    protected DatabaseContext()
    {
        
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer()
            {
                CustomerId = 1,
                FirstName = "Jan",
                LastName = "Byl",
                PhoneNumber = "987654321"
            }
        });

        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
            {
                new Concert()
                {
                    ConcertId = 1,
                    Name = "krakowki koncert",
                    Date = DateTime.Parse("2025-09-02"),
                    AvailableTickets = 50
                },
                new Concert()
                {
                    ConcertId = 2,
                    Name = "warszawski koncert",
                    Date = DateTime.Parse("2025-08-08"),
                    AvailableTickets = 70
                }
            }
        );

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
            {
                new Ticket()
                {
                    TicketId = 1,
                    SerialNumber = "442",
                    SeatNumber = 213
                },
                new Ticket()
                {
                    TicketId = 2,
                    SerialNumber = "443",
                    SeatNumber = 211
                },
                new Ticket()
                {
                    TicketId = 3,
                    SerialNumber = "444",
                    SeatNumber = 212
                }
            }
        );

        modelBuilder.Entity<TicketConcert>().HasData(new List<TicketConcert>()
            {
                new TicketConcert()
                {
                    TicketConcertId = 1,
                    TicketId = 1,
                    ConcertId = 1, 
                    Price = 38.42
                },
                new TicketConcert() 
                { TicketConcertId = 2,
                    TicketId = 2, 
                    ConcertId = 2, 
                    Price = 44.24
                }
            }
        );

        modelBuilder.Entity<PurchasedTicket>().HasData(new List<PurchasedTicket>()
            {
                new PurchasedTicket()
                {
                    TicketConcertId = 1,
                    CustomerId = 1,
                    PurchaseDate = DateTime.Parse("2025-09-01"),
                },
                new PurchasedTicket(){
                TicketConcertId = 2,
                CustomerId = 2,
                PurchaseDate = DateTime.Parse("2025-08-07"),
            }
            }
        );
    }
}