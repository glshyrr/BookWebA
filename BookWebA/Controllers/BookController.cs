using BookWebA.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookWebA.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext dbContext;
        public BookController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ActionResult Cheapest()
        {
            var cheapestBooks = dbContext.Books.OrderBy(x => x.Price).Take(3).ToList();
            return View(cheapestBooks);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
