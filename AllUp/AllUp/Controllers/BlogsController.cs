using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
