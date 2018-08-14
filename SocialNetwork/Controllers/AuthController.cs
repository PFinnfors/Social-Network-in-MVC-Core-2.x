using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult _login()
        {
            return PartialView();
        }

        public IActionResult _register()
        {
            return PartialView();
        }
    }
}