using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Areas.Manage.ViewModel;
using Pustok.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            BookViewModel bookVW = new BookViewModel
            {
                Books = _context.Book.Include(x => x.Author).Include(x=>x.Genre).ToList(),

            };
            return View(bookVW);
        }
    }
}
