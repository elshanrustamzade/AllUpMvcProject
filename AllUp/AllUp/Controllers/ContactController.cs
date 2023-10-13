using AllUp.Helpers;
using AllUp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AllUp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM contactVM)
        {
            string message = $"< p > Subject:{contactVM.Subject}< p >< br >" +
                             $"< p > Message:{contactVM.Message}< p >< br >" +
                             $"< p > By name:{contactVM.Name}< p >< br >" +
                             $"< p > By email:{contactVM.Email}< p >< br >";

            await Helper.SendMailAsync("Muraciet", message, "elshanrustamzada22@gmail.com");
            ViewBag.Text = "Mesaj gonderildi.";
            return View();
        }
    }
}
