using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
