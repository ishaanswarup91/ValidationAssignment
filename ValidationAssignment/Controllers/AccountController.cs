using ValidationAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace ValidationAssignment.Controllers
{
    public class AccountController : Controller
    {       
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ValidationMessage = "Registration Success!";
            }
            else
            {
                ViewBag.ValidationMessage = "Registration Failed!";
            }
            return View();
        }
    }
}
