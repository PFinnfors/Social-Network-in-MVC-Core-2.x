using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Data;
using SocialNetwork.Models.AuthModels;
using SocialNetwork.Models.Database;
using System.Linq;

namespace SocialNetwork.Controllers
{
    public class AuthController : Controller
    {
        public SocialUserContext DbContext { get; set; }

        public AuthController(SocialUserContext dbContext)
        {
            DbContext = dbContext;
        }

        public IActionResult _login(LoginModel model)
        {
            model.IsPost = false;
            return PartialView(model);
        }

        [HttpPost]
        public IActionResult _login(LoginModel model, bool p = false)
        {

            SocialUser user = null;
            if (model.Email != null)
            {
                user = DbContext.SocialUsers.FirstOrDefault(x => x.Email.ToLower() == model.Email.ToLower());

                if (user == null)
                {
                    //Email doesn't exist
                    ModelState.AddModelError("Email", "There is no account for this email.");
                }
                else if (model.Password != null && user.Password != model.Password)
                {
                    //Wrong password
                    ModelState.AddModelError("Password", "Wrong password. It's case-sensitive!");
                }

                if (ModelState.IsValid)
                {
                    //Success
                    return PartialView("_LoginRedirect", user);
                }
            }

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
            var user = DbContext.SocialUsers.FirstOrDefault(x => x.Email.ToLower() == model.Email.ToLower());

            if (user != null)
            {
                ModelState.AddModelError("Email", $"An account already exists for the email {model.Email}.");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //Save registered user
                    var newUser = new SocialUser(model.Email, model.Password);
                    DbContext.SocialUsers.Add(newUser);
                    DbContext.SaveChanges();

                    return PartialView("_LoginRedirect", newUser);
                }
            }

            model.IsPost = true;
            return PartialView(model);
        }

        public IActionResult _profile(SocialUser user)
        {
            return PartialView(user);
        }
    }
}