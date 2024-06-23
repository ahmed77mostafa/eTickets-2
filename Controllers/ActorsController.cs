using eTickets_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_2.Controllers
{
    public class ActorsController : Controller
    {
        private readonly dbContext _context;
        public ActorsController(dbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.actors.ToList();
            return View(data);
        }
    }
}
