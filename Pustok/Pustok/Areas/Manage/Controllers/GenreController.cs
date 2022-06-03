using Microsoft.AspNetCore.Mvc;
using Pustok.Areas.Manage.ViewModel;
using Pustok.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Areas.Manage.Controllers
{
    [Area("manage")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;

        public GenreController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            GenreViewModel genreVW = new GenreViewModel
            {
                Genres = _context.Genres.ToList(),
            
            };
            return View(genreVW);
        }
    }
}
