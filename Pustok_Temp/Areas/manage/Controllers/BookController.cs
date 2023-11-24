using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Temp.DAL;
using Pustok_Temp.Models;

namespace Pustok_Temp.Areas.manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        AppDbContext _context;
        readonly IWebHostEnvironment _environment;

        public BookController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.books.Include(b => b.Authors).ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

    //    [HttpPost]
    //    public async Task<IActionResult> Create(Book book)
    //    {
    //        if(!book.ImageFile.ContentType.Contains("image"))
    //        { 
    //            return View();
    //        }
    //        if(book.ImageFile.Length > 2097152)
    //        {
    //            return View();
    //    }
    //}
}
