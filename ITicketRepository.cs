using OrderTickets.Models;
using System.Collections.Generic;

namespace OrderTickets
{
    public class ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicketById(int id);
        void AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
    }
    
}
