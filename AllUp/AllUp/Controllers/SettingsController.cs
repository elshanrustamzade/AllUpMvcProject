using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
