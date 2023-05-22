using Microsoft.AspNetCore.Mvc;

namespace P231_Model.Controllers
{
    public class AccountController:Controller
    {
        public IActionResult Register()
        {
            TempData["Success"] = "Please check the email";
            return RedirectToAction("Index","Home");
        }
    }
}
