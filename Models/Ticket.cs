using System;

namespace OrderTickets.Models
{
    public class Ticket
    {
        public int Id { get; set; } 
        public string PassengerName { get; set; }
        public string SeatNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public bool IsRegistered { get; set; }
    }
}
