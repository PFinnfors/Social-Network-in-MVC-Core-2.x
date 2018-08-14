using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SocialNetwork.Controllers
{
    public class PresentationController : Controller
    {
        public IActionResult _Video()
        {
            return View();
        }
    }
}