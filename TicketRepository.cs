﻿using OrderTickets.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderTickets
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicketById(int id);
        void AddTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
    }

    public class TicketRepository : ITicketRepository
    {
        private List<Ticket> _tickets;

        public TicketRepository() 
        {
            _tickets = new List<Ticket>();
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _tickets;
        }

        public Ticket GetTicketById(int id) 
        {
            /*
            foreach (var ticket in _tickets)
            {
                if (ticket.Id == id) return ticket;
                return null;
            }
            */

            return _tickets.FirstOrDefault(t => t.Id == id);
        }

        public void AddTicket(Ticket ticket)
        {
            ticket.Id = _tickets.Count + 1;
            _tickets.Add(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            var exisitingTicket = _tickets.FirstOrDefault(t =>t.Id == ticket.Id);
            if (exisitingTicket != null)
            {
                exisitingTicket.PassengerName = ticket.PassengerName;
                exisitingTicket.SeatNumber = ticket.SeatNumber;
                exisitingTicket.Price = ticket.Price;
                exisitingTicket.IsRegistered = ticket.IsRegistered;
            }
        }
    }
}
