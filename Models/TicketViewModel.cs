using System;

namespace OrderTickets.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
        public string PassengerName { get; set; }
        public int SeatNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public bool IsRegistered { get; set; }
        
    }
}
