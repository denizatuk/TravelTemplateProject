using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
