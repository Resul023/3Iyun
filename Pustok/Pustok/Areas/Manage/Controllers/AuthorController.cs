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
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            AuthorViewModel authorVW = new AuthorViewModel
            {
                Authors = _context.Authors.ToList(),
            };
            return View(authorVW);
        }
    }
}
