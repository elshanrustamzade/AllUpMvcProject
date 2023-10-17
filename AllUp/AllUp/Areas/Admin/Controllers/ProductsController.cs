using AllUp.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Products.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Brands = await _db.Brands.ToListAsync();
            ViewBag.Tags = await _db.Tags.ToListAsync();
            ViewBag.MainCategories = await _db.Categories.Where(x => x.IsMain).ToListAsync();
            ViewBag.ChildCategories = (await _db.Categories.Include(x => x.Children).FirstOrDefaultAsync())?.Children;
            return View();
        }
    }
}
