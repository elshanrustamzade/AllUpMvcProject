using AllUp.DAL;
using AllUp.Models;
using AllUp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AllUp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new()
            {
                Categories = await _db.Categories.Where(x => x.IsMain).ToListAsync(),
                Sliders = await _db.Sliders.ToListAsync(),
            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return View();
        }

       
    }
}