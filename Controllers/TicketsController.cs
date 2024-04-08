using Microsoft.AspNetCore.Mvc;

namespace OrderTickets.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
