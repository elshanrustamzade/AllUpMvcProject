using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
