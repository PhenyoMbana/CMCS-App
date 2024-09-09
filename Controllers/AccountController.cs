using CMCSAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMCSAPP.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // For simplicity, assume successful login.
                // Redirect to the main page (Dashboard)
                return RedirectToAction("Main", "Dashboard");
            }
            return View(model);
        }
    }

}
