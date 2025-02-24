using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HomeController : Controller
{
    private readonly MovieDBContext _context;

    public HomeController(MovieDBContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IActionResult Index()
    {
        var movies = _context.Movies.ToList();  // Ensure movies are being retrieved
        return View(movies);
    }
}


