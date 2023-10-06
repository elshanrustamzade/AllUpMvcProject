using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
      
    }
}
