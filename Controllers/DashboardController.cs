using Microsoft.AspNetCore.Mvc;

namespace CMCSAPP.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }

        public IActionResult ManagerDashboard()
        {
            return View();
        }

        public IActionResult LecturerDashboard()
        {
            return View();
        }

        public IActionResult ViewPendingClaims()
        {
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult ViewClaimsHistory()
        {
            return View();
        }
        public IActionResult ApproveClaims()
        {
            return View();
        }

        public IActionResult ApproveClaim(int id)
        {
            // Handle claim approval logic here
            return RedirectToAction("ViewPendingClaims");
        }
    }
}
