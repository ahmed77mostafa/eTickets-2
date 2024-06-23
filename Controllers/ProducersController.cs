using eTickets_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_2.Controllers
{
    public class ProducersController : Controller
    {
        private readonly dbContext _context;
        public ProducersController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.producers.ToListAsync();
            return View(allProducers);
        }
    }
}
