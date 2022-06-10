using Microsoft.AspNetCore.Mvc;
using MyBiz.DAL;
using MyBiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Profession> professions = _context.Professions.ToList();
            return View();
        }
    }
}
