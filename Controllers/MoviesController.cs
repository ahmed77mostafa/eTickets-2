using eTickets_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets_2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly dbContext _context;
        public MoviesController(dbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.movies.ToListAsync();
            return View(allMovies);
        }
    }
}
