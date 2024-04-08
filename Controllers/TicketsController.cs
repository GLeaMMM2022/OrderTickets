using Microsoft.AspNetCore.Mvc;
using OrderTickets.Models;

namespace OrderTickets.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketsController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }



        public IActionResult Index()
        {
            var tickets = _ticketRepository.GetAllTickets();
            return View();
        }

        public IActionResult AddOrEdit(int id)
        {
            Ticket ticket;
            if (id == 0)
            {
                ticket = new Ticket();
            }
            else
            {
                ticket = _ticketRepository.GetTicketById(id);
            }
            return View(ticket);
        }

        public IActionResult AddOrEdit(Ticket ticket) 
        {
            if (ModelState.IsValid)
            {
                if(ticket.Id == 0) 
                {
                    ticket.PurchaseDate = DateTime.Now;
                    _ticketRepository.AddTicket(ticket);
                }
                else
                {
                    _ticketRepository.UpdateTicket(ticket);
                }
                return RedirectToAction("Index"));
            }
            return View(ticket);
        }
    }
}
