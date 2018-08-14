using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models.AuthModels;

namespace SocialNetwork.Controllers
{
    public class AuthController : Controller
    {

        public IActionResult _login(LoginModel model)
        {
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult _login(LoginModel model, bool p = false)
        {
            return PartialView(model);
        }

        public IActionResult _register(RegisterModel model)
        {
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult _register(LoginModel model, bool p = false)
        {
            return PartialView(model);
        }
    }
}