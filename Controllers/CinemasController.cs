using eTickets_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_2.Controllers
{
    public class CinemasController : Controller
    {
        private readonly dbContext _context;
        public CinemasController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
