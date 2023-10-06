using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
