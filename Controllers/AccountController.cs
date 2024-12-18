using HW_ASP_11.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP_11.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate saving the user to a database
                TempData["SuccessMessage"] = "Registration successful!";
                return RedirectToAction("Register");
            }

            return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult IsUsernameAvailable(string username)
        {
            // Simulate a username uniqueness check
            if (username.ToLower() == "admin")
            {
                return Json($"Username '{username}' is already taken.");
            }

            return Json(true);
        }
    }
}
