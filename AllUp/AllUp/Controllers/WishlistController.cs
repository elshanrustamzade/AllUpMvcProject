using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
