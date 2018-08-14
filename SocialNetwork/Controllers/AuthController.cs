using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models.AuthModels;

namespace SocialNetwork.Controllers
{
    public class AuthController : Controller
    {

        public IActionResult _login(LoginModel model)
        {
            model.IsPost = false;
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult _login(LoginModel model, bool p = false)
        {
            model.IsPost = true;
            return PartialView(model);
        }

        public IActionResult _register(RegisterModel model)
        {
            model.IsPost = false;
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult _register(RegisterModel model, bool p = false)
        {
            model.IsPost = true;
            return PartialView(model);
        }
    }
}