using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
