using AllUp.Helpers;
using AllUp.Models;
using AllUp.ViewModels;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
