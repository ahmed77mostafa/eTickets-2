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
            var allMovies = await _context.movies.Include(n => n.cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}
