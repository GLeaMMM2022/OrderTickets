using OrderTickets.Models;
using System.Collections.Generic;

namespace OrderTickets
{
    public interface ITicketRepository1
    {
        void AddTicket(Ticket ticket);
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicketById(int id);
        void UpdateTicket(Ticket ticket);
    }
}