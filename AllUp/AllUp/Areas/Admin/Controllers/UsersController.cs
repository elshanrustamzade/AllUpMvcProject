using Microsoft.AspNetCore.Mvc;

namespace AllUp.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
